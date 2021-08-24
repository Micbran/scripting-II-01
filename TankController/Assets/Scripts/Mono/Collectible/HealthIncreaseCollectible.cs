using UnityEngine;

public class HealthIncreaseCollectible : Collectible
{
    [SerializeField] private int healthAmount = 1;


    protected override void Collect(Player player)
    {
        player.IncreaseHealth(healthAmount);
    }
}
