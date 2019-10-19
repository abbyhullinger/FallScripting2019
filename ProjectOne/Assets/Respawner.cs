using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = System.Numerics.Vector3;

public class Respawner : MonoBehaviour
{
    public FloatData value;
    public FloatData minValue;  
    private void Start()
    {
        if (value == minValue)
        {
            transform.position = UnityEngine.Vector3.back;
        }
    }
}
