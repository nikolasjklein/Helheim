using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbow_Controller : MonoBehaviour
{
    public GameObject boltPrefab;
    public Transform boltSpawn;
    public float boltSpeed = 30f;
    public float lifeTime = 3f;

    public void Start()
    {
        
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    private void Fire()
    {
        GameObject bolt = Instantiate(boltPrefab);

        bolt.transform.position = boltSpawn.position;
        Vector3 rotation = bolt.transform.rotation.eulerAngles;
        bolt.transform.rotation = Quaternion.Euler(rotation.x, transform.eulerAngles.y, rotation.z);

        bolt.GetComponent<Rigidbody>().AddForce(boltSpawn.forward * boltSpeed, ForceMode.Impulse);
        StartCoroutine(DestroyBoltOverTime(bolt, lifeTime));
    }

    private IEnumerator DestroyBoltOverTime(GameObject bolt, float delay)
    {
        yield return new WaitForSeconds(delay);

        Destroy(bolt);
    }
}
