using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UICoroutine : MonoBehaviour
{
    public UnityEvent startEvent, repeatEvent, endEvent;
    public float seconds;
    public int counter = 3;
    public bool canRun; 
    private WaitForSeconds wfsObj;
    private Text textLabel;

    private void Awake()
    {
        wfsObj = new WaitForSeconds(seconds);
        textLabel = GetComponent<Text>();
    }

    public void CallCoroutine()
    {
        StartCoroutine(RunCoroutine());
    }

    IEnumerator RunCoroutine()
    {
        startEvent.Invoke();

        while (counter > 0)
        {
            repeatEvent.Invoke();
            yield return wfsObj;
            counter--;
        }

        while (canRun)
        {
            repeatEvent.Invoke();
            yield return wfsObj;
            counter--;
        }
        
        endEvent.Invoke();
    }
}
