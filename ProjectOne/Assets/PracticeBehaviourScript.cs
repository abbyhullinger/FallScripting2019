using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeBehaviourScript : MonoBehaviour
{
    private Renderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            _renderer.material.color = new Color(1f, 0.51f, 0.43f);
        }
    }
}
