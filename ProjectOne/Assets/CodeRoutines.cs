using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CodeRoutines : MonoBehaviour
{
   public UnityEvent startEvent, repeatEvent, endEvent; 
   public float seconds = 10f;
   private int counter = 10;
   public bool canRun;
   private WaitForSeconds wfsObj;

   private void Awake()
   {
      wfsObj = new WaitForSeconds(seconds);
   }

   public void CallCoroutine()
   {
      StartCoroutine(routine: RunCoroutine()); 
   }
   IEnumerator RunCoroutine()
   {
      while (canRun)
      {
        repeatEvent.Invoke();
        yield return wfsObj;
        counter--;
      }
      endEvent.Invoke();

    }
}
