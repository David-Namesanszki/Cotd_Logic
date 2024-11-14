using Cotd_Data.Models.Enemies;
using Cotd_Logic.Models.Games.Decks;

namespace Cotd_Logic.Models.Enemies;

public class Enemy
{
	public Enemy()
	{
	}
	public Enemy(EnemyData enemyData)
	{
		Id = enemyData.Id;
		Deck = new Deck(enemyData.Deck);
		Image = enemyData.Image;
	}
	public EnemyData ToData()
	{
		return new EnemyData
		{
			Id = Id,
			Deck = Deck.ToData(),
			Image = Image,
		};
	}
	public string Id { get; set; } = Guid.NewGuid().ToString();
    public Deck Deck { get; set; } = new Deck();
	public string Image { get; set; } = string.Empty;

	
}
