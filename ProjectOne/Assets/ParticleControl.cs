using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ParticleControl : MonoBehaviour
{
    public ParticleSystem particles;

    private void OnMouseDown()
    {
        particles.Emit(count:100);
    }
}
