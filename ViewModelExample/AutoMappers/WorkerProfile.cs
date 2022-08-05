using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModelExample.Models;
using ViewModelExample.Models.ViewModels;

namespace ViewModelExample.AutoMappers
{
    public class WorkerProfile:Profile
    {
        public WorkerProfile()
        {
            CreateMap<Worker, WorkerCreateVM>();
            CreateMap<WorkerCreateVM, Worker>();
        }
    }
}
