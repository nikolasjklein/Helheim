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
        Vector3 viewDirection = MainCamera.transform.position - this.transform.position;
        var viewAngle = Vector3.Angle(transform.forward, viewDirection);

        //Debug.Log(viewAngle + SpriteRenderer.sprite.name);
        viewAngle += 22.5f;
        ///////////////////////////////////////////////////////////////
        if (/*viewAngle >= 327.5f && */viewAngle <= 45)
        {
            SpriteRenderer.sprite = sprite1;
        }

        else if (viewAngle >= 45 && viewAngle <= 90)
        {
            SpriteRenderer.sprite = sprite2;
        }

        else if (viewAngle >= 90 && viewAngle <= 135)
        {
            SpriteRenderer.sprite = sprite3;
        }

        else if (viewAngle >= 135 && viewAngle <= 180)
        {
            SpriteRenderer.sprite = sprite4;
        }

        if (MainCamera.transform.position.z + MainCamera.transform.position.x < this.transform.position.z + MainCamera.transform.position.x)
        {
            if (viewAngle <= 45)
            {
                SpriteRenderer.sprite = sprite8;
            }

            else if (viewAngle >= 45 && viewAngle <= 90)
            {
                SpriteRenderer.sprite = sprite7;
            }

            else if (viewAngle >= 90 && viewAngle <= 135)
            {
                SpriteRenderer.sprite = sprite6;
            }

            else if (viewAngle >= 135 && viewAngle <= 180)
            {
                SpriteRenderer.sprite = sprite5;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward * 2);
    }
}
