using UnityEngine;
using UnityEngine.Events;

public class WeaponsHandler : MonoBehaviour
{
    public enum LifeSpan
    {
        Life,
        TimeSpan,
        Death, 
    }

    public LifeSpan currentLifeSpan;

    public UnityEvent OnLifeEvent, OnTimeSpanEvent, OnDeathEvent; 
    void Update()
    {
        switch (currentLifeSpan)
        {
            case LifeSpan.Life:
                OnLifeEvent.Invoke();
                break;
            case LifeSpan.TimeSpan:
                OnTimeSpanEvent.Invoke();
                break;
            case LifeSpan.Death:
                OnDeathEvent.Invoke();
                break;
        }
    }
}
