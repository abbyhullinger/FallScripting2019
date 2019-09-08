using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Variables : MonoBehaviour
{
    public float floatValue = 5.5f;
    public int intValue = 20;
    public string stringValue = "Bob";
    public int firePower = 1;
    public long longValue = 10;
    public double doubleValue = 30;
    public UnityEvent Event;
    public int charValue = 22;


    private void OnMouseOver() => Event.Invoke();

    private void OnBecameVisible()
    {
        Event.Invoke();
    }


    // private void OnTriggerEnter(Collider other)
    //{
    //  Event.Invoke();
    // }    


    // private void OnMouseDrag()
    //{
    //    Event.Invoke();
    //}
}
