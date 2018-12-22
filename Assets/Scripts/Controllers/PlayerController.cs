using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int playerLife;

    public Text playerHealth;

    public void Start()
    {
        playerLife = 100;
    }

    public void Update()
    {
        playerHealth.text = playerLife.ToString();
        //Debug.Log(playerLife);
    }
}
