using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA;
using Vector3 = System.Numerics.Vector3;

public class Respawner : MonoBehaviour
{
    public FloatData value;
    public FloatData minValue;
    public Vector3 position;
 
    private void Start()
    {
        if (value == minValue)
        {
            position.X = 0;
            position.Y = 0; 

        }
    }
}
