using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowAxeManager : MonoBehaviour
{
    //camera which isolates weapons from the rest of the scene
    public Camera weaponCam;
    //camera which shows everything but the weapons
    public Camera playerCam;
    //axe object which is visible when running around the game
    public GameObject ogAxeObject;
    //axe object which gets thrown
    public GameObject axeObject;
    //rigidbody for the axe which is thrown for collision
    public Rigidbody axe;
    //throw force
    public float throwForce = 50;
    //transforms for target and curve point
    public Transform target, curve_point;
    //vector3 throwing the og position
    private Vector3 old_pos;
    //bool to check if axe is returning already
    public bool isReturning = false;
    public float time = 0.0f;
    //callback delay
    public float delay = 5f;


    public void Start()
    {
        //enable og axe object and disable the axe object which gets thrown
        ogAxeObject.gameObject.SetActive(true);
        axeObject.gameObject.SetActive(false);
    }

    public void Update()
    {
        //check for RMB press
        if (Input.GetMouseButtonDown(1))
        {
            //run ThrowAxe function
            ThrowAxe();

            //start coroutine to call back axe (5 seconds until it gets called back)
            StartCoroutine(CallBackAxe(axe.gameObject, delay));
        }

        //call back axe
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
                //run ResetAxe function
                ResetAxe();
            }
        }
    }

    //coroutine for calling back axe
    private IEnumerator CallBackAxe(GameObject axe, float delay)
    {
        yield return new WaitForSeconds(delay);

        //run ReturnAxe function
        ReturnAxe();
    }

    //function for throwing axe
    public void ThrowAxe()
    {
        //disable og axe object and enable the axe object which gets thrown
        ogAxeObject.gameObject.SetActive(false);
        axeObject.gameObject.SetActive(true);

        isReturning = false;
        axe.isKinematic = false;
        axe.transform.parent = null;
        axe.AddForce(playerCam.transform.TransformDirection(Vector3.forward) * throwForce, ForceMode.Impulse);
        axe.AddTorque(axe.transform.TransformDirection(Vector3.right) * 100, ForceMode.Impulse);
    }

    //function for returning axe
    public void ReturnAxe()
    {
        old_pos = axe.position;
        isReturning = true;
        axe.velocity = Vector3.zero;
        axe.isKinematic = true;
        time = 0f;
    }

    //function for resetting axe
    public void ResetAxe()
    {
        isReturning = false;
        axe.transform.parent = transform;
        axe.position = target.position;
        axe.rotation = target.rotation;
        ogAxeObject.gameObject.SetActive(true);
        axeObject.gameObject.SetActive(false);
    }

    //vector3 for getting Bezier Quadratic Curve Point
    Vector3 getBezierQuadraticCurvePoint(float t, Vector3 p0, Vector3 p1, Vector3 p2)
    {
        float u = 1 - t;
        float tt = t * t;
        float uu = u * u;
        Vector3 p = (uu * p0) + (2 * u * t * p1) + (tt * p2);
        return p;
    }
}
