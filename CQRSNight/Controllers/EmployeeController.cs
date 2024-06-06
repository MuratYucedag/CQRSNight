﻿using CQRSNight.MediatorDesignPattern.Commands;
using CQRSNight.MediatorDesignPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSNight.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IActionResult> EmployeeList()
        {
            var values = await _mediator.Send(new GetEmployeeQuery());
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("EmployeeList");
        }

        public async Task<IActionResult> RemoveEmployee(int id)
        {
            await _mediator.Send(new RemoveEmployeeCommand(id));
            return RedirectToAction("EmployeeList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateEmployee(int id)
        {
            var value = await _mediator.Send(new GetEmployeeByIdQuery(id));
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateEmployee(UpdateEmployeeCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("EmployeeList");
        }
    }
}
