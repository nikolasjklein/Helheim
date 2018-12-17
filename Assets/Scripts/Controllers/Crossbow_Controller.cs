using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbow_Controller : MonoBehaviour
{
    public Camera weaponCam;

    public GameObject boltPrefab;

    public Transform boltSpawn;

    public float boltSpeed = 30f;
    public float lifeTime = 3f,AmmoCount,fireRate;

    private float holdTimer;

    public AudioClip shotFiredClip;

    public AudioSource camAudioSource;

    public void Start()
    {
        
    }

    public void Update()
    {

        if (Input.GetKeyDown(0))
        {
            holdTimer = 0;
        }

        if (Input.GetMouseButton(0))
        {
            holdTimer += 1*Time.deltaTime;
        }

        if (Input.GetMouseButtonUp(0) && AmmoCount>0 && fireRate<=0)
        {
            if (holdTimer < 1)
            {
                //Normal Shot
                Fire();
                AmmoCount -= 1;
            }
            else
            {
                //Charged Shot
                ChargedFire();
                AmmoCount -= 1;
            }

        }

        if (fireRate > 0)
        {
            fireRate -= 1*Time.deltaTime;
        }

    }

    private void Fire()
    {
        GameObject bolt = Instantiate(boltPrefab);

        fireRate = 1;

        //Un Comment when added
        //camAudioSource.clip = shotFiredClip;
        //camAudioSource.Play();

        bolt.transform.position = boltSpawn.position;
        bolt.GetComponent<CrossbowBoltController>().Damage = 1;
        Vector3 rotation = bolt.transform.rotation.eulerAngles;
        bolt.transform.rotation = Quaternion.Euler(rotation.x, transform.eulerAngles.y, rotation.z);

        bolt.GetComponent<Rigidbody>().AddForce(weaponCam.transform.forward * boltSpeed, ForceMode.Impulse);
        StartCoroutine(DestroyBoltOverTime(bolt, lifeTime));
    }

    private void ChargedFire()
    {
        GameObject bolt = Instantiate(boltPrefab);
        Debug.Log("ChargedFire");
        fireRate = 2.5f;
        bolt.GetComponent<CrossbowBoltController>().Damage = 5;
        holdTimer = 0;
        //Un Comment when added
        //camAudioSource.clip = shotFiredClip;
        //camAudioSource.Play();

        bolt.transform.position = boltSpawn.position;
        Vector3 rotation = bolt.transform.rotation.eulerAngles;
        bolt.transform.localEulerAngles = new Vector3(weaponCam.transform.rotation.x, weaponCam.transform.rotation.y, weaponCam.transform.rotation.z);

        bolt.GetComponent<Rigidbody>().AddForce(boltSpawn.forward * boltSpeed, ForceMode.Impulse);
        StartCoroutine(DestroyBoltOverTime(bolt, lifeTime));
    }

    private IEnumerator DestroyBoltOverTime(GameObject bolt, float delay)
    {
        yield return new WaitForSeconds(delay);

        Destroy(bolt);
    }
}
