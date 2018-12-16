using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowAxeManager : MonoBehaviour
{
    public Camera weaponCam;
    public Camera playerCam;
    public GameObject ogAxeObject;
    public GameObject axeObject;
    public Rigidbody axe;
    public float throwForce = 50;
    public Transform target, curve_point;
    private Vector3 old_pos;
    public bool isReturning = false;
    public float time = 0.0f;
    public float delay = 5f;


    public void Start()
    {
        ogAxeObject.gameObject.SetActive(true);
        axeObject.gameObject.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            ThrowAxe();

            StartCoroutine(CallBackAxe(axe.gameObject, delay));
        }

        if (isReturning)
        {
            if (time < 1.0f)
            {
                axe.position = getBezierQuadraticCurvePoint(time, old_pos, curve_point.position, target.position);
                axe.rotation = Quaternion.Slerp(axe.transform.rotation, target.rotation, 50 * Time.deltaTime);
                time += Time.deltaTime;
            }

            else
            {
                ResetAxe();
            }
        }
    }

    private IEnumerator CallBackAxe(GameObject axe, float delay)
    {
        yield return new WaitForSeconds(delay);

        ReturnAxe();
    }

    public void ThrowAxe()
    {
        ogAxeObject.gameObject.SetActive(false);
        axeObject.gameObject.SetActive(true);

        isReturning = false;
        axe.isKinematic = false;
        axe.transform.parent = null;
        axe.AddForce(playerCam.transform.TransformDirection(Vector3.forward) * throwForce, ForceMode.Impulse);
        axe.AddTorque(axe.transform.TransformDirection(Vector3.right) * 100, ForceMode.Impulse);
    }

    public void ReturnAxe()
    {
        old_pos = axe.position;
        isReturning = true;
        axe.velocity = Vector3.zero;
        axe.isKinematic = true;
        time = 0f;
    }

    public void ResetAxe()
    {
        isReturning = false;
        axe.transform.parent = transform;
        axe.position = target.position;
        axe.rotation = target.rotation;
        ogAxeObject.gameObject.SetActive(true);
        axeObject.gameObject.SetActive(false);
    }

    Vector3 getBezierQuadraticCurvePoint(float t, Vector3 p0, Vector3 p1, Vector3 p2)
    {
        float u = 1 - t;
        float tt = t * t;
        float uu = u * u;
        Vector3 p = (uu * p0) + (2 * u * t * p1) + (tt * p2);
        return p;
    }
}
