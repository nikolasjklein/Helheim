using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerLife;

    public void Start()
    {
        playerLife = 100;
    }

    public void Update()
    {
        Debug.Log(playerLife);
    }
}
