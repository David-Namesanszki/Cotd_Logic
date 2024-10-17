namespace Cotd_Logic.Models;

public abstract class Card
{
    public int Id { get; set; }
    public string Name { get; set; }
	public string Description { get; set; }
	public string Image { get; set; }
    public int EnvoyCost { get; set; }
}
