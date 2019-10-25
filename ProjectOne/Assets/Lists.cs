using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Lists : ScriptableObject
{
    public List<string> stringList;
    public List<int> inList;
    public List<float> floatList;

    public List<GameObject> gameObjectList;
    public List<FloatData> floatDataList; 
}
