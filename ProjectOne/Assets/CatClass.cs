using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CatClass : MonoBehaviour
{
    public UnityEvent doesStuff;
    private void OnMouseDown()
    {
        doesStuff.Invoke();
    }
}
