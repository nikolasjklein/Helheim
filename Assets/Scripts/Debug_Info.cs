using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Debug_Info : MonoBehaviour
{
    public GameObject DebugCanvas;

    public Text VelocityX;
    public Text VelocityY;
    public Text VelocityZ;

    public Text DeviceModel;
    public Text DeviceName;
    public Text DeviceType;
    public Text GraphicsDeviceID;
    public Text GraphicsDeviceName;
    public Text GraphicsDeviceType;
    public Text GraphicsMemorySize;
    public Text OperatingSystem;
    public Text OperatingSystemFamily;
    public Text ProcessorCount;
    public Text ProcessorFrequency;
    public Text ProcessorType;

    public Text Fps;
    public float deltaTime;

    public GameObject Player;

    public bool isToggled = false;

    public void Start()
    {
        isToggled = false;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F11))
        {
            if (isToggled)
            {
                isToggled = false;
            }

            else if (!isToggled)
            {
                isToggled = true;
            }
        }

        if (isToggled)
        {
            DebugCanvas.gameObject.SetActive(true);
        }

        else if (!isToggled)
        {
            DebugCanvas.gameObject.SetActive(false);
        }

        VelocityX.text = Player.GetComponent<CharacterController>().velocity.x.ToString();
        VelocityY.text = Player.GetComponent<CharacterController>().velocity.y.ToString();
        VelocityZ.text = Player.GetComponent<CharacterController>().velocity.z.ToString();

        DeviceModel.text = SystemInfo.deviceModel;
        DeviceName.text = SystemInfo.deviceName;
        DeviceType.text = SystemInfo.deviceType.ToString();
        GraphicsDeviceID.text = SystemInfo.graphicsDeviceID.ToString();
        GraphicsDeviceName.text = SystemInfo.graphicsDeviceName;
        GraphicsDeviceType.text = SystemInfo.graphicsDeviceType.ToString();
        GraphicsMemorySize.text = SystemInfo.graphicsMemorySize.ToString();
        OperatingSystem.text = SystemInfo.operatingSystem;
        OperatingSystemFamily.text = SystemInfo.operatingSystemFamily.ToString();
        ProcessorCount.text = SystemInfo.processorCount.ToString();
        ProcessorFrequency.text = SystemInfo.processorFrequency.ToString();
        ProcessorType.text = SystemInfo.processorType;

        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
        Fps.text = Mathf.Ceil(fps).ToString();
    }
}
