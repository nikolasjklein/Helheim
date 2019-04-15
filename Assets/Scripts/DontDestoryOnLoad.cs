using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestoryOnLoad : MonoBehaviour
{
    public GameObject Player;

    public void Update()
    {
        DontDestroyOnLoad(Player.gameObject);
    }
}
