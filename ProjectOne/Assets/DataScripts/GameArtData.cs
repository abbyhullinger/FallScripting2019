using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameArtData : ScriptableObject
{
    public Sprite sprite;
    public Color spriteColor = Color.red;
    public GameObject prefab;
    public Animation animation;
     

}
//this is the parent script for playerdata and weapondata;
//we didn't make a createassetmenu at the top because we are just using this as a base not something we want;
//to be editing; 