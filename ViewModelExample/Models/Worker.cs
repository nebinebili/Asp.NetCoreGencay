using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModelExample.Models.ViewModels;

namespace ViewModelExample.Models
{
    public class Worker
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Position { get; set; }

        public int Salary { get; set; }

        public bool MaritalStatus { get; set; }

        #region implicit

        /*public static implicit operator WorkerCreateVM(Worker model)
        {
            return new WorkerCreateVM
            {
                Name = model.Name,
                Surname = model.Surname
            };
        }

        public static implicit operator Worker(WorkerCreateVM model)
        {
            return new Worker
            {
                Name = model.Name,
                Surname = model.Surname
            };
        }
        */

        #endregion

        #region Explicit

        /*public static explicit operator WorkerCreateVM(Worker model)
        {
            return new WorkerCreateVM
            {
                Name = model.Name,
                Surname = model.Surname
            };
        }

        public static explicit operator Worker(WorkerCreateVM model)
        {
            return new Worker
            {
                Name = model.Name,
                Surname = model.Surname
            };
        }
        */
        #endregion


    }
}
