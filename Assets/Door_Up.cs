using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Up : MonoBehaviour
{
    public Animator DoorUp_Animator;

    public void Start()
    {
        DoorUp_Animator.SetBool("isTriggered", false);
    }

    public void Update()
    {
        
    }

    public void OnTriggerStay(Collider other)
    {
        Debug.Log("Player is in Trigger Area");

        if (other.tag == "Player")
        {
            Debug.Log("Player is tagged Player");
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Pressed Space");
                DoorUp_Animator.SetBool("isTriggered", true);
                StartCoroutine(CloseDoor(5));
            }
        }
    }

    public void CloseDoor()
    {
        DoorUp_Animator.SetBool("isTriggered", false);
    }

    private IEnumerator CloseDoor(float delay)
    {
        yield return new WaitForSeconds(delay);

        CloseDoor();
    }
}
