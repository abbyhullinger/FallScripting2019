using System;
using UnityEngine;
using UnityEngine.XR.WSA;

[CreateAssetMenu]
public class ShieldData : GameArtData
{
    public int shieldPower = 10;
    public Behaviour behaviour;
    public PositionalLocatorState positionlife;
    public TimeSpan lifeTime; 
}
