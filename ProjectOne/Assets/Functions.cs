using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    public string playerName;
    private int myNumber;
    public float speed = 5;
    public GameObject player;
    public Color playerColor = Color.red;
  
    
    void Start()
    {
        ConfigureGameObject();

    }

    
    private GameObject ConfigureGameObject()
    {
        var newPlayer = Instantiate(player);
        newPlayer.layer = 0;
        newPlayer.active = true;
        newPlayer.tag = "Player";
        newPlayer.transform.position = Vector3.zero;
        newPlayer.name = playerName;
        newPlayer.GetComponent<Renderer>().material.color = playerColor;
        
        return newPlayer;
    }

    private void OnTriggerEnter(Collider other)
    {
        speed = IncreaseSpeed(multiplier: 2);
    }

    private float IncreaseSpeed (float multiplier)
    {
        return speed * multiplier;
    }
    
    private string WelcomePlayer()
    {
        //Add player to database;
        //Give player weapons;
        
        return playerName + "Welcome to the game!";
    }

    private int AddNumbers(int a, int b)
    {
        print(a + b);
        return a + b;
    }

}
