using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA;

[CreateAssetMenu]
public class PotionData : GameArtData
{
    public int potionPower = 10;
    public Animation animation;
    public ParticleSystem particles;
    public WorldAnchor position; 
}
// not sure how to give different 'potions' or items different effects, for now it could be a;
//full health regenerator or something!; 