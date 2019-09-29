using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR.WSA;

[CreateAssetMenu]
public class PlayerData : ScriptableObject
{
    public float fairyDust = 1f;
    public int flyingPower = 5;
    public float magicPower = 20f;
    public int magicDanceMovesPower = 10;
    
    
    //fairyDust is weapon, flyingPower is stamina, magicPower is HP;
    //May need to make these clearer but just for fun;
  
    public void UpdateFairyDust(float amount)
    {
        fairyDust += amount;
    }

    private void UpdateFlyingPower(int amount)
    {
        flyingPower -= amount;
    }

    public void UpdateMagicPower(float amount)
    {
        magicPower += amount;
    }

    public void UpdatemagicDanceMovesPower(int amount)
    {
        magicDanceMovesPower += amount;
    }
   
}
