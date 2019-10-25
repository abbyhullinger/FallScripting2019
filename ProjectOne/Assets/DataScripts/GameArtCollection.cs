using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
[CreateAssetMenu]
public class GameArtCollection : ScriptableObject
{
    public List<GameArtData> collectionList;

    public void AddData(GameArtData obj)
    {
        for (var i = 0; i < collectionList.Count; i++)
        {
            if (collectionList.Contains(obj))
            {
               collectionList.Add(obj);
            }
        }
    }

    public void RemoveLastItem()
    {
        if (!collectionList.Contains(null))
        {
            collectionList.RemoveAt(collectionList.Count-1);
        }
    }

}
//removeat removes a specific number on your list. removeall says what it is. null means null