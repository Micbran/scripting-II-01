using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureCollectible : Collectible
{
    [SerializeField] private int treasureAmount = 1;

    protected override void Collect(Player player)
    {
        player.AddScore(treasureAmount);
    }
}
