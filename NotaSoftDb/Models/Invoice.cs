namespace NotaSoftDb.Models;

public class Invoice : BaseModel
{
	public string Name { get; set; } = string.Empty;
	public string Cpf { get; set; } = string.Empty;
	public double Price { get; set; }
	public int Amount { get; set; }
}
