using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : GameArtData
{
   public FloatData health;
   public List<WeaponData> weapons;
   public List<PotionData> potion; 
   public ClothesData shirt;
   public ClothesData pants;
   public ClothesData hat; 
}
