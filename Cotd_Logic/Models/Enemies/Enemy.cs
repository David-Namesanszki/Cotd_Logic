using Cotd_Data.Models.Enemies;

namespace Cotd_Logic.Models.Enemies;

public class Enemy
{
	public Enemy()
	{
	}
    public Enemy(IList<string> cardIds, string image)
    {
        CardIds = new List<string>(cardIds);
		Image = image;
    }

    public Enemy(EnemyData enemyData)
	{
		Id = enemyData.Id;
		CardIds = CardIds;
		Image = enemyData.Image;
	}
	public EnemyData ToData()
	{
		return new EnemyData
		{
			Id = Id,
			CardIds = CardIds,
			Image = Image,
		};
	}
	public string Id { get; set; } = Guid.NewGuid().ToString();
    public IList<string> CardIds { get; set; } = [];
	public string Image { get; set; } = string.Empty;

	
}
