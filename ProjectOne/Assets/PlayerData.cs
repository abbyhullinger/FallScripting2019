using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR.WSA;

[CreateAssetMenu]
public class PlayerData : ScriptableObject
{
    public float value = 1f;

    public void UpdateValue(float amount)
    {
        value += amount; 
    }
}
