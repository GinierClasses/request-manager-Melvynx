namespace RequestManager.Views
{
    partial class RequestManagerView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_titre = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.label_priority = new System.Windows.Forms.Label();
            this.rich_input_description = new System.Windows.Forms.RichTextBox();
            this.input_title = new System.Windows.Forms.TextBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.cb_priority = new System.Windows.Forms.ComboBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cb_filter_status = new System.Windows.Forms.ComboBox();
            this.label_filtre = new System.Windows.Forms.Label();
            this.label_filtrer_status = new System.Windows.Forms.Label();
            this.input_filter_id = new System.Windows.Forms.TextBox();
            this.label_filter_id = new System.Windows.Forms.Label();
            this.dgv_request = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_request)).BeginInit();
            this.SuspendLayout();
            // 
            // label_titre
            // 
            this.label_titre.AutoSize = true;
            this.label_titre.Location = new System.Drawing.Point(22, 9);
            this.label_titre.Name = "label_titre";
            this.label_titre.Size = new System.Drawing.Size(37, 17);
            this.label_titre.TabIndex = 0;
            this.label_titre.Text = "Titre";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(193, 9);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(79, 17);
            this.label_description.TabIndex = 1;
            this.label_description.Text = "Description";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(796, 9);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(48, 17);
            this.label_status.TabIndex = 2;
            this.label_status.Text = "Status";
            // 
            // label_priority
            // 
            this.label_priority.AutoSize = true;
            this.label_priority.Location = new System.Drawing.Point(964, 9);
            this.label_priority.Name = "label_priority";
            this.label_priority.Size = new System.Drawing.Size(53, 17);
            this.label_priority.TabIndex = 3;
            this.label_priority.Text = "Priorité";
            // 
            // rich_input_description
            // 
            this.rich_input_description.Location = new System.Drawing.Point(196, 29);
            this.rich_input_description.Name = "rich_input_description";
            this.rich_input_description.Size = new System.Drawing.Size(559, 145);
            this.rich_input_description.TabIndex = 4;
            this.rich_input_description.Text = "";
            // 
            // input_title
            // 
            this.input_title.Location = new System.Drawing.Point(25, 29);
            this.input_title.Name = "input_title";
            this.input_title.Size = new System.Drawing.Size(146, 22);
            this.input_title.TabIndex = 5;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(799, 29);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(148, 24);
            this.cb_status.TabIndex = 6;
            // 
            // cb_priority
            // 
            this.cb_priority.FormattingEnabled = true;
            this.cb_priority.Location = new System.Drawing.Point(967, 29);
            this.cb_priority.Name = "cb_priority";
            this.cb_priority.Size = new System.Drawing.Size(148, 24);
            this.cb_priority.TabIndex = 7;
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(967, 108);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(120, 30);
            this.btn_new.TabIndex = 8;
            this.btn_new.Text = "Nouveau";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(967, 144);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(120, 30);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Sauver";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(967, 180);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(120, 30);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Supprimer";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cb_filter_status
            // 
            this.cb_filter_status.FormattingEnabled = true;
            this.cb_filter_status.Location = new System.Drawing.Point(25, 251);
            this.cb_filter_status.Name = "cb_filter_status";
            this.cb_filter_status.Size = new System.Drawing.Size(148, 24);
            this.cb_filter_status.TabIndex = 11;
            this.cb_filter_status.TextChanged += new System.EventHandler(this.cb_filter_status_TextChanged);
            // 
            // label_filtre
            // 
            this.label_filtre.AutoSize = true;
            this.label_filtre.Location = new System.Drawing.Point(9, 193);
            this.label_filtre.Name = "label_filtre";
            this.label_filtre.Size = new System.Drawing.Size(39, 17);
            this.label_filtre.TabIndex = 12;
            this.label_filtre.Text = "Filtre";
            // 
            // label_filtrer_status
            // 
            this.label_filtrer_status.AutoSize = true;
            this.label_filtrer_status.Location = new System.Drawing.Point(22, 231);
            this.label_filtrer_status.Name = "label_filtrer_status";
            this.label_filtrer_status.Size = new System.Drawing.Size(48, 17);
            this.label_filtrer_status.TabIndex = 13;
            this.label_filtrer_status.Text = "Status";
            // 
            // input_filter_id
            // 
            this.input_filter_id.Location = new System.Drawing.Point(196, 253);
            this.input_filter_id.Name = "input_filter_id";
            this.input_filter_id.Size = new System.Drawing.Size(146, 22);
            this.input_filter_id.TabIndex = 14;
            this.input_filter_id.TextChanged += new System.EventHandler(this.input_filter_id_TextChanged);
            // 
            // label_filter_id
            // 
            this.label_filter_id.AutoSize = true;
            this.label_filter_id.Location = new System.Drawing.Point(193, 231);
            this.label_filter_id.Name = "label_filter_id";
            this.label_filter_id.Size = new System.Drawing.Size(181, 17);
            this.label_filter_id.TabIndex = 15;
            this.label_filter_id.Text = "Numéro de la demande (id)";
            // 
            // dgv_request
            // 
            this.dgv_request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_request.Location = new System.Drawing.Point(12, 294);
            this.dgv_request.Name = "dgv_request";
            this.dgv_request.RowHeadersWidth = 51;
            this.dgv_request.RowTemplate.Height = 24;
            this.dgv_request.Size = new System.Drawing.Size(1103, 315);
            this.dgv_request.TabIndex = 16;
            this.dgv_request.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_request_CellClick);
            this.dgv_request.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRequest_CellFormatting);
            // 
            // RequestManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 621);
            this.Controls.Add(this.dgv_request);
            this.Controls.Add(this.label_filter_id);
            this.Controls.Add(this.input_filter_id);
            this.Controls.Add(this.label_filtrer_status);
            this.Controls.Add(this.label_filtre);
            this.Controls.Add(this.cb_filter_status);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.cb_priority);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.input_title);
            this.Controls.Add(this.rich_input_description);
            this.Controls.Add(this.label_priority);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_titre);
            this.Name = "RequestManagerView";
            this.Text = "RequestManagerView";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_request)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titre;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_priority;
        private System.Windows.Forms.RichTextBox rich_input_description;
        private System.Windows.Forms.TextBox input_title;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.ComboBox cb_priority;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cb_filter_status;
        private System.Windows.Forms.Label label_filtre;
        private System.Windows.Forms.Label label_filtrer_status;
        private System.Windows.Forms.TextBox input_filter_id;
        private System.Windows.Forms.Label label_filter_id;
        private System.Windows.Forms.DataGridView dgv_request;
    }
}