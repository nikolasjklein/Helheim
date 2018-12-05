using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Debug_Info : MonoBehaviour
{
    public Text VelocityX;
    public Text VelocityY;
    public Text VelocityZ;

    public Text Fps;
    public float deltaTime;

    public GameObject Player;

    public void Update()
    {
        VelocityX.text = Player.GetComponent<CharacterController>().velocity.x.ToString();
        VelocityY.text = Player.GetComponent<CharacterController>().velocity.y.ToString();
        VelocityZ.text = Player.GetComponent<CharacterController>().velocity.z.ToString();

        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
        Fps.text = Mathf.Ceil(fps).ToString();
    }
}
