using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestManager.Models
{
    class Request
    {
        /// <summary>
        /// Request instanciateur.
        /// Class qui permet de géré des requêtes comme des "Jira"
        /// </summary>
        /// <param name="id">id de la requete</param>
        /// <param name="title">titre de la requete</param>
        /// <param name="description">id de la requete</param>
        /// <param name="createdOn">date de création de la requête</param>
        /// <param name="updatedOn">date de modification de la requête</param>
        /// <param name="status">status de la requete</param>
        /// <param name="priority">priorité de la requete</param>
        public Request(int id, string title, string description, DateTime createdOn, DateTime updatedOn, Status status, Priority priority)
        {
            Id = id;
            Title = title;
            Description = description;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            Status = status;
            Priority = priority;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }


    }
}