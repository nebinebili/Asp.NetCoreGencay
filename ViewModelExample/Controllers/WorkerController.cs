using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModelExample.Business;
using ViewModelExample.Models;
using ViewModelExample.Models.ViewModels;

namespace ViewModelExample.Controllers
{
    public class WorkerController : Controller
    {
        public IMapper _mapper;

        public WorkerController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(WorkerCreateVM workerCreateVM)
        {
            #region Manual
            //Worker worker = new Worker()
            //{
            //    Name = workerCreateVM.Name,
            //    Surname = workerCreateVM.Surname
            //};
            #endregion

            #region Implicit
            //Worker worker = workerCreateVM;
            //WorkerCreateVM createVM = worker;
            #endregion

            #region Explicit
            //Worker worker =(Worker)workerCreateVM;
            //WorkerCreateVM createVM = (WorkerCreateVM)worker;
            #endregion

            #region Reflection
            //Worker worker=TypeConversion.Conversion<WorkerCreateVM, Worker>(workerCreateVM);
            //WorkerCreateVM createVM=TypeConversion.Conversion<Worker, WorkerCreateVM>(worker);
            #endregion

            #region AutoMapper
            Worker worker=_mapper.Map<Worker>(workerCreateVM);
            WorkerCreateVM workerCreate = _mapper.Map<WorkerCreateVM>(worker);
            #endregion
            return View();
        }

        public IActionResult WorkerLists()
        {
            List<WorkerListVM> workers = new List<Worker>
            {
                new Worker{ Name="A1",Surname="B1",Position="Position1"},
                new Worker{ Name="A2",Surname="B2",Position="Position2"},
                new Worker{ Name="A3",Surname="B3",Position="Position3"},
                new Worker{ Name="A4",Surname="B4",Position="Position4"},
            }.Select(w=>new WorkerListVM
            {
                Name=w.Name,
                Surname=w.Surname,
                Position=w.Position
            }).ToList();

            return View(workers);
        }

        public IActionResult GetOneMoreModel()
        {
            //var tupleobject = (new Worker(), new Product(), new Client()); //Tuple obyekt 

            XVM xobject = new XVM 
            { 
                Client = new Client(),
                Product = new Product(),
                Worker = new Worker() 
            };
            return View();
        }
    }
}
