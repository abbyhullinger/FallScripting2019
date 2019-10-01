using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEvent;
  //  public UnityEvent mouseDown;
    
   private void OnTriggerEnter(Collider other)
   {
       triggerEvent.Invoke();
       
   }
   
   // private void OnMouseDown(Collider other)
  //  {
  //      triggerEvent.Invoke();
  //  }
}
