using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class GameArtCollection : ScriptableObject
{
    public List<GameArtData> collectionList;

    public void AddData(GameArtData obj)
    {
        if (!obj.collected)
        {
            collectionList.Add(obj);
            obj.collected = true;
        }
       
    }
    
}
//this will receive weapon data, so we can go around and collect weapons in the game if we do List<WeaponDta>;
//List<SriptableObject> means we can get any scriptable objects but this isn't specific;
//So we did GameArtData; 
//the adddata function is going to add gameart to the collection list! and anyone can call it cause it's public;