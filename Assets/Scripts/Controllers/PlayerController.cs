using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //player health
    public int playerLife;
    //text for displaying the player health
    public Text playerHealth;

    public void Start()
    {
        //set player health to 100 at start
        playerLife = 100;
    }

    public void Update()
    {
        //display the player health in UI
        playerHealth.text = playerLife.ToString();
        //Debug.Log(playerLife);
    }
}
