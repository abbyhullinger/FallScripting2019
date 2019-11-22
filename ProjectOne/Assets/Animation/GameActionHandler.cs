using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameAction gameActionObj;
    public UnityEvent handlerEvent; 
    void Start()
    {
        gameActionObj.action = RaiseHandler; 
    }

    public void RaiseHandler()
    {
        handlerEvent.Invoke();
    }
 }
//this can handle any incoming things, the animation statemachine will fire off game action
//anything that will handle the gameaction is going to do something, this is deligation
