using NotaSoftDb.Models;
using NotaSoftDb.Repositories;

namespace NotaSoftDb.UseCases.InvoiceCases;

public class CreateInvoice
{
	public static async Task Execute(Invoice invoice)
	{
		var dbContext = new CustomDbContext();
		var invoiceRepository = new InvoiceRepository(dbContext);

		invoiceRepository.Create(invoice);

		await dbContext.SaveChangesAsync();
	}
}
