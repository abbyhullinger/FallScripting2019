using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PotionData : GameArtData
{
    public int potionPower = 10;
    public Animation animation;
    public ParticleSystem particles; 
    
}
// not sure how to give different 'potions' or items different effects, for now it could be a;
//full health regenerator or something!; 