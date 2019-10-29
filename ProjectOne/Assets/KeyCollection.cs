using System;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class KeyCollection : ScriptableObject
{
    public bool key = true;
    public Type door;
    public List<GameArtData> keyCollectionList;

    public void AddKey(GameArtData doorKey)
    {
        for (int i = 0; i < keyCollectionList.Capacity; i++)
        {
            if (keyCollectionList.Contains(doorKey))
            {
                keyCollectionList.Add(doorKey);
            }

        }
    }

    private void OnDestroy()
    {
        if (key == true)
        {
            Destroy(GameObject.FindObjectOfType(door));
            OnDestroy();
        }
    }
}
