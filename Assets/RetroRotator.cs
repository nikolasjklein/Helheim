using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class RetroRotator : MonoBehaviour
{
    public int directions = 8;
    public Camera MainCamera;
    public bool MirrorLeft = true;
    SpriteRenderer SpriteRenderer;
    Animator Anim;
    float minMirrorAngle = 0;
    float maxMirrorAngle = 0;

    void Start()
    {
        Anim = this.GetComponent<Animator>();
        SpriteRenderer = this.GetComponent<SpriteRenderer>();
        if (directions <= 0)
        {
            directions = 1;
        }
        minMirrorAngle = (360 / directions) / 2;
        maxMirrorAngle = 180 - minMirrorAngle;
    }

    void Update()
    {

        Vector3 viewDirection = -new Vector3(MainCamera.transform.forward.x, 0, MainCamera.transform.forward.z);
        var viewAngle = Vector3.Angle(transform.forward, viewDirection);
        var cross = Vector3.Cross(transform.forward, viewDirection);
        if (cross.y < 0)
        {
            viewAngle = 360 - viewAngle;
        }

        Anim.SetFloat("ViewAngle", viewAngle);
        if (MirrorLeft)
        {
            SpriteRenderer.flipX = (viewAngle >= minMirrorAngle && viewAngle <= maxMirrorAngle);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward * 2);
    }
}
