namespace Cotd_Logic.Models.Common;

public class Entity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
}
