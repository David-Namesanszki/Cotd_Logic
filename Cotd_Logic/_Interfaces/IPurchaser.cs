namespace Cotd_Logic._Interfaces;

public interface IPurchaser<T>
{
	bool IsPurchasable(T cost);
	void Purchase(T cost);
}
