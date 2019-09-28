using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : ScriptableObject
{
    public float fairyDust = 1f;
    public int flyingPower = 5;
    public float magicPower = 20f;
    //fairyDust is weapon, flyingPower is stamina, magicPower is HP;
    //May need to make these clearer but just for fun;

    public void UpdateFairyDust(float amount)
    {
        fairyDust += amount;
    }

    private void UpdateFlyingPower(int amount)
    {
        flyingPower += amount;
    }

    public void UpdateMagicPower(float amount)
    {
        magicPower += amount;
    }
}
