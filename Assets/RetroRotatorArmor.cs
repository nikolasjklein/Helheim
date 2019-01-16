using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetroRotatorArmor : MonoBehaviour
{
    public int directions = 8;
    public Camera MainCamera;
    SpriteRenderer SpriteRenderer;
    float minMirrorAngle = 0;
    float maxMirrorAngle = 0;

    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;
    public Sprite sprite7;
    public Sprite sprite8;

    void Start()
    {
        SpriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector3 viewDirection = -new Vector3(MainCamera.transform.forward.x, 0, MainCamera.transform.forward.z);
        var viewAngle = Vector3.Angle(transform.forward, viewDirection);

        Debug.Log(viewAngle);

        ///////////////////////////////////////////////////////////////

        if (/*viewAngle >= 327.5f && */viewAngle <= 22.5f)
        {
            SpriteRenderer.sprite = sprite1;
        }

        else if (viewAngle >= 22.6f && viewAngle <= 67.5f)
        {
            SpriteRenderer.sprite = sprite2;
        }

        else if (viewAngle >= 67.5f && viewAngle <= 102.5f)
        {
            SpriteRenderer.sprite = sprite3;
        }

        else if (viewAngle >= 102.5f && viewAngle <= 147.5f)
        {
            SpriteRenderer.sprite = sprite4;
        }

        else if (viewAngle >= 147.5f && viewAngle <= 192.5f)
        {
            SpriteRenderer.sprite = sprite5;
        }

        else if (viewAngle >= 192.5f && viewAngle <= 237.5f)
        {
            SpriteRenderer.sprite = sprite6;
        }

        else if (viewAngle >= 237.5f && viewAngle <= 282.5f)
        {
            SpriteRenderer.sprite = sprite7;
        }

        else if (viewAngle >= 282.5f && viewAngle <= -327.5f)
        {
            SpriteRenderer.sprite = sprite8;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward * 2);
    }
}
