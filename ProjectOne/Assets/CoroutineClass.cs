using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements;

public class CoroutineClass : MonoBehaviour
{
    public bool canRun = true;
    public IntData index;
    public float seconds = 1f;
    public bool regeneration = true;
    public UnityEvent triggerEvent;
    private WaitForSeconds wfsObj; 

    public void Run()
    {
        wfsObj = new WaitForSeconds(seconds);
        StartCoroutine(OnRun());
    }
    IEnumerator OnRun()
    {
        while (index.value > 0)
        {
            Debug.Log(index.value);
            //index--;
            yield return wfsObj;
            
            triggerEvent.Invoke();
            yield return new WaitForSeconds(1f);
            Debug.Log("Run");
        }

        while (regeneration)
        {
            
        }
        
    }

    void Update()
    {
        
    }
}
