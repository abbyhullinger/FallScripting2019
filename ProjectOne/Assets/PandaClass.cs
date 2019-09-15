using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PandaClass : MonoBehaviour
{
    public UnityEvent getBamboo;

    private void OnMouseDown()
    {
        getBamboo.Invoke();
    }
}
