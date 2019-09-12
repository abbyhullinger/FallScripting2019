using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseE : MonoBehaviour
{
   public UnityEvent mouseEvent;

   private void OnMouseDown()
   {
      mouseEvent.Invoke();
   }
}
