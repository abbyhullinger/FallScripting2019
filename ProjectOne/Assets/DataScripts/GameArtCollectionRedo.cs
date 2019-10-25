using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class GameArtCollectionRedo : MonoBehaviour
{
   public List<GameArtData> listCollection;

   public void AddData(GameArtData obj)
   {
      foreach (var gameArt in listCollection)
      {
         if (listCollection.Contains(obj))
         {
            listCollection.Add(obj);
         }
      }
   }

   public void RemoveItem()
   {
      if (!listCollection.Contains(null))
      {
         listCollection.RemoveAt(listCollection.Count-1);
      }
   }
}
