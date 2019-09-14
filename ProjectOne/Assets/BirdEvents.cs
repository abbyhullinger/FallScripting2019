using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements;

public class BirdEvents : MonoBehaviour
{
  public UnityEvent birdEvent;

  private void OnMouseDrag()
  {
    birdEvent.Invoke();
  }
}
