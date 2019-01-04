using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAxeManager : MonoBehaviour
{
    public Camera weaponCam;
    public float range = 1.5f;
    public int damage = 5;
    public GameObject axe;

	void Start ()
    {
		
	}

	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
	}

    public void Attack()
    {
        RaycastHit hit;

        if (Physics.Raycast(weaponCam.transform.position, weaponCam.transform.forward, out hit, range) && hit.transform.tag == "Enemy")
        {
            hit.transform.GetComponent<Enemy>().health = hit.transform.GetComponent<Enemy>().health - damage;
            Debug.Log("Enemy Hit");
        }
    }
}
