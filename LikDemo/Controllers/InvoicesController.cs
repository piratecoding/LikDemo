using AutoMapper;
using LikDemo.Models;
using LikDemo.Models.ViewModels;
using LikDemo.Services.Implementation;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LikDemo.Controllers
{
    public class InvoicesController : Controller
    {
        private readonly IInvoicesService _invoiceService;
        private readonly IMapper _mapper;

        public InvoicesController(IInvoicesService invoiceService, IMapper mapper)
        {
            _invoiceService = invoiceService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var data = _invoiceService.GetAll().Result;
            var viewData = new List<InvoiceViewModel>();
            foreach (var item in data.Data)
            {
                viewData.Add(_mapper.Map<InvoiceViewModel>(item));
            }

            return View("Index", viewData);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var defaultLine = GetDefaultLine();
            var lines = new List<Line>();
            lines.Add(defaultLine);
            var newInvoiceRequest = new CreateInvoiceRequest
            {
                Lines = lines.ToArray()
            };

            return View(newInvoiceRequest);
        }

        [HttpPost]
        public IActionResult Create(CreateInvoiceRequest model)
        {
            if (ModelState.IsValid)
            {
                _invoiceService.CreateInvoice(model);

                return RedirectToAction("Index");
            }

            return View();
        }

        private Line GetDefaultLine()
        {
            var defaultLine = new Line
            {
                UnitNetPrice = null,
                Description = string.Empty,
                Quantity = null,
                VatRate = null,
                DiscountType = null,
                DiscountValue = null
            };

            return defaultLine;
        }
    }
}