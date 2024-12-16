using Cotd_Data.Models.Enemies;
using Cotd_Logic.Models.Common;

namespace Cotd_Logic.Models.Enemies;

public class Enemy : Entity
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
    public IList<string> CardIds { get; set; } = [];
	public string Image { get; set; } = string.Empty;

	
}
