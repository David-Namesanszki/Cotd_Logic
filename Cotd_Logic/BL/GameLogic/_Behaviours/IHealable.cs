namespace Cotd_Logic.BL.GameLogic.Behaviours;

public interface IHealable
{
    public int Health { get; set; }
    public bool CanBeHealed { get; set; }
}
