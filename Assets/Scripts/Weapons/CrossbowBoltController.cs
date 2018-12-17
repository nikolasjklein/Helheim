using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossbowBoltController : MonoBehaviour {

    private RaycastHit hit;

    public Vector3 objectHit;

    public GameObject FXPoint;

    public ParticleSystem hitFX;

    private Rigidbody rbb;

    public int backSpeed = 11,Damage;

    private int aliveTimer, afterHitTimer;

    private bool aliveDivide,afterHitStart;

    public bool moveBack;

    public bool addedBack,tooAdd = false;


    //BOX COLLIDER HAS BEEN RAISED TO ENSURE IT DOESN'T DETECT THE GROUND, DO NOT ADJUST

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            //objectHit = other.gameObject.transform;

            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

            Instantiate(hitFX, FXPoint.transform.position,transform.rotation);
            hitFX.time = 0;

            if (!addedBack)
            {
                //Destroy(gameObject.GetComponent<Rigidbody>());
                tooAdd = true;
                afterHitStart = true;
            }

        }

    }

    private void OnTriggerStay(Collider other)
    {
        rbb.velocity = Vector3.zero;
        rbb.angularVelocity = Vector3.zero;
        rbb.constraints = RigidbodyConstraints.FreezePositionY;

        if (other.tag == "Wall" || other.tag == "Enemy")
        {
            moveBack = true;

            if (!addedBack && !tooAdd)
            {
                //Rigidbody rb = gameObject.AddComponent<Rigidbody>();

                //rb.constraints = RigidbodyConstraints.FreezePositionY;
                addedBack = true;
            }

            if (other.tag == "Enemy")
            {
                //other.transform.gameObject.GetComponent<EnemyHealthController>().Health -= Damage;
            }

        }



    }

    private void Start()
    {
        rbb = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {

        if (afterHitStart)
        {
            afterHitTimer += 1;
        }

        if (!addedBack && !tooAdd && afterHitTimer>1)
        {
            //Rigidbody rb = gameObject.AddComponent<Rigidbody>();

            //rb.constraints = RigidbodyConstraints.FreezePositionY;
            addedBack = true;
        }

        aliveTimer += 1;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 0.4f) && objectHit == new Vector3(0,0,0))
        {
            if (hit.transform.gameObject.tag == "Wall"|| hit.transform.gameObject.tag == "Enemy")
            {
                Debug.Log(hit.transform.position);
                objectHit = hit.point;
            }

        }

        if (aliveTimer > 10 && !aliveDivide)
        {
            backSpeed /= 2;
            aliveDivide = true;
        }

        if (moveBack)
        {
            transform.position += -transform.right * backSpeed * Time.deltaTime;
            moveBack = false;
            tooAdd = false;
            Debug.Log("Move Back = True");
        }

        if (objectHit != new Vector3(0,0,0))
        {
            //transform.position = objectHit;
            Debug.Log("Object Hit != Null: " + objectHit);
        }

    }

}


/*
 *         if (Physics.Raycast(transform.position, transform.forward, out hit, 1.6f) && objectHit == null)
        {
            Debug.Log(hit.transform.position);
            objectHit = hit.transform;
            Destroy(gameObject.GetComponent<Rigidbody>());
        }
 * 
 * */
