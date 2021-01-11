using RequestManager.Controllers;
using RequestManager.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RequestManager.Views
{
    public partial class RequestManagerView : Form
    {
        /// id selected if request is edited
        private int _id = -1;
        private readonly RequestController _requestController = new RequestController();
        /// <summary>
        /// Instanciateur de la vue.
        /// </summary>
        public RequestManagerView()
        {
            InitializeComponent();
            InitializeApp();
        }

        private void InitializeApp()
        {
            foreach (var status in Enum.GetValues(typeof(Status)))
            {
                cb_filter_status.Items.Add(status);
                cb_status.Items.Add(status);
            }
            foreach (var priority in Enum.GetValues(typeof(Priority)))
                cb_priority.Items.Add(priority);
            UpdateDataGridView();
        }

        private void dgvRequest_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
                e.Value = ((DateTime)dgv_request.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).ToShortDateString();
            if (e.ColumnIndex == 4)
                e.Value = ((DateTime)dgv_request.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).ToShortDateString();
        }

        private void UpdateDataGridView(List<Request> requests = null)
        {
            BindingSource requestsSource = new BindingSource
            {
                DataSource = requests ?? _requestController.GetAll()
            };
            dgv_request.AutoGenerateColumns = true;
            dgv_request.DataSource = requestsSource;
            dgv_request.ReadOnly = true;
        }

        private void SetRequestInForm(Request request = null)
        {
            input_title.Text = request != null ? request.Title : "";
            rich_input_description.Text = request != null ? request.Description : "";
            cb_status.Text = request != null ? request.Status.ToString() : "";
            cb_priority.Text = request != null ? request.Priority.ToString() : "";
            input_title.Text = request != null ? request.Title : "";
            _id = request != null ? request.Id : -1;
            UpdateDataGridView();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            SetRequestInForm();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (_id == -1)
            {
                MessageBox.Show("Il faut séléctionner une requête pour en supprimer une.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _requestController.Delete(_id);
                SetRequestInForm();
            } catch (Exception)
            {
                MessageBox.Show("Une erreur c'est produite.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string title = input_title.Text;
            string description = rich_input_description.Text;
            string status = cb_status.Text;
            string priority = cb_priority.Text;

            if (String.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Le titre ne peut pas être vide.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("La description ne peut pas être vide.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isValidPriority = Priority.TryParse(priority, out Priority priorityEnum);
            bool isValidStatus = Status.TryParse(status, out Status statusEnum);

            if (!isValidPriority || !isValidStatus)
            {
                MessageBox.Show("Le status ou la priorité ne sont pas dans la liste.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_id == -1)
            {
                _requestController.Create(title, description, DateTime.Now, DateTime.Now, statusEnum, priorityEnum);
            } else
            {
                _requestController.Update(_id, title, description, _requestController.GetById(_id).CreatedOn, DateTime.Now, statusEnum, priorityEnum);
            }
            SetRequestInForm();
        }

        private void cb_filter_status_TextChanged(object sender, EventArgs e)
        {
            string statusFilter = cb_filter_status.Text;
            bool isValidStatus = Status.TryParse(statusFilter, out Status statusEnum);
            if (!isValidStatus)
            {
                MessageBox.Show("Le status ne fait pas partie du combobox.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UpdateDataGridView(_requestController.GetByStatusOrderByPriority(statusEnum));
        }

        private void input_filter_id_TextChanged(object sender, EventArgs e)
        {
            string idString = input_filter_id.Text;
            bool isValidId = Int32.TryParse(idString, out int id);
            if (!isValidId)
                return;
            var request = _requestController.GetById(id);
            if (request == null)
                return;
            UpdateDataGridView(new List<Request>() { request });
        }

        private void dgv_request_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (index == -1)
                return;

            // in the theory, dataGridView index match with my list Index, but I'm not sure so I add a try/catch
            try
            {
                DataGridViewCellCollection cells = dgv_request.Rows[e.RowIndex].Cells;
                _id = (int)cells[0].Value;
                if (_id != -1)
                {
                    SetRequestInForm(_requestController.GetById(_id));
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Index is out of list.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
