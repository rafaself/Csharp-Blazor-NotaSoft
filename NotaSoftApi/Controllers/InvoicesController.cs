using Microsoft.AspNetCore.Mvc;
using NotaSoftDb.Models;
using NotaSoftDb.UseCases.Invoice.ListInvoices;
using NotaSoftDb.UseCases.InvoiceCases;

namespace NotaSoftApi.Controllers;

[ApiController]
[Route("[controller]")]
public class InvoicesController(ILogger<InvoicesController> logger) : ControllerBase
{

	private readonly ILogger<InvoicesController> _logger = logger;

	[HttpGet]
	public async Task<List<Invoice>> Get()
	{
		return await ListInvoices.Execute();
	}

	[HttpPost]
	public async Task Post(Invoice invoice)
	{
		await CreateInvoice.Execute(invoice);
	}


}
