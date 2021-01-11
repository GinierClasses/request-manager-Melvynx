using RequestManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RequestManager.Controllers
{
    class RequestController
    {
        private readonly List<Request> _requestsList = new List<Request>();
        /// <summary>
        /// Crée un request donnée en paramêtre.
        /// </summary>
        /// <param name="obj">Ne peux pas crée un Object si il est déjà `.Equals` à un autre.</param>
        public void Create(string title, string description, DateTime createdOn, DateTime updatedOn, Status status, Priority priority)
        {
            var request = new Request(GetNewId(), title, description, createdOn, updatedOn, status, priority);
            var isExisting = _requestsList.Any(o => o.Equals(request));
            if (isExisting)
            {
                return;
            }

            _requestsList.Add(request);
        }
        /// <summary>
        /// Update l'request donnée en paramêtre
        /// </summary>
        /// <param name="request">Item à modifié</param>
        public void Update(int id, string title, string description, DateTime createdOn, DateTime updatedOn, Status status, Priority priority)
        {
            var editedItemIndex = _requestsList.FindIndex(o => o.Id == id);

            if (editedItemIndex == -1)
            {
                throw new Exception("ID do not exist in the List.");
            }

            _requestsList[editedItemIndex] = new Request(id, title, description, createdOn, updatedOn, status, priority);
        }
        /// <summary>
        /// Supprime l'request lié à l'id si il exist.
        /// </summary>
        /// <param name="id">Id de l'request à supprimer.</param>
        /// <returns>List des autres requests.</returns>
        public void Delete(int id)
        {
            var deletedItem = _requestsList.Find(o => o.Id == id);

            if (deletedItem == null)
            {
                throw new Exception("Invalid Request ID.");
            }
            _requestsList.Remove(deletedItem);
        }
        /// <summary>
        /// Donne les requests
        /// </summary>
        /// <returns>List d'request</returns>
        public List<Request> GetAll()
        {
            return _requestsList;
        }
        /// <summary>
        /// Return l'element correspondant à l'id ou null
        /// </summary>
        /// <param name="id">Id de l'element rechercher.</param>
        /// <returns></returns>
        public Request GetById(int id)
        {
            return _requestsList.FirstOrDefault(request => request.Id == id);
        }
        /// <summary>
        /// Return une list de request correspondant au status donné au paramètre et ordré en  function de la priorité.
        /// </summary>
        /// <param name="status">Status des elements rechercher.</param>
        /// <returns></returns>
        public List<Request> GetByStatusOrderByPriority(Status status)
        {
            return _requestsList.Where(request => request.Status == status)
                .OrderByDescending(request => request.Priority)
                .ToList();
        }

        private int GetNewId()
        {
            if (_requestsList.Count == 0)
            {
                return 1;
            }
            else
            {
                return _requestsList.Last().Id + 1;
            }
        }
    }
}
