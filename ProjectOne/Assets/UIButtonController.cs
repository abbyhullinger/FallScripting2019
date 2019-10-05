using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonController : MonoBehaviour
{
    private Button buttonClicker;

    private void Awake()
    {
        buttonClicker = GetComponent<Button>();
    }

    public void UpdateButton(FloatData data)
    {
        buttonClicker.name = data.value.ToString();
    }
}
