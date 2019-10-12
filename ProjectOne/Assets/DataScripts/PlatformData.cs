using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PlatformData : GameArtData
{
   public Vector3 position;
   public Movement constantMotion;
   public FloatData damage;
   public FloatData health; 
   
}
//which platforms can have health or damage or none, for which platforms move or not; 