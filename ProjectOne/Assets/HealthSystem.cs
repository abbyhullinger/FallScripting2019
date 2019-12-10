using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public GameObject healthText;
    public static int theHealth;

    public void Update()
    {
        healthText.GetComponent<Text>().text = "HEALTH: " + theHealth;
    }
}
