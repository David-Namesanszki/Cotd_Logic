namespace Cotd_Logic.BL.GameLogic.Behaviours;

public interface IDamageable
{
    public int HitPoints { get; set; }
    public void TakeDamage(int amount);
}
