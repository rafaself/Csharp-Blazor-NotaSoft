namespace NotaSoftDb.UseCases.Invoice.ListInvoices;
using NotaSoftDb.Models;
using NotaSoftDb.Repositories;

public class ListInvoices
{
	public async static Task<List<Invoice>> Execute()
	{
		var dbContext = new CustomDbContext();
		var invoiceRepository = new InvoiceRepository(dbContext);

		var invoices = await invoiceRepository.List();

		return invoices;
	}
}
