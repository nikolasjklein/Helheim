using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerLocationUpdate : MonoBehaviour
{
    public Animator locationUpdateAnimator;
    public Text locationUpdateText;
    public string locationName;
    public float delay = 5f;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            locationUpdateText.text = locationName;
            locationUpdateAnimator.SetBool("isTriggered", true);
            StartCoroutine(DisableLocationText(delay));
        }
    }

    private IEnumerator DisableLocationText(float delay)
    {
        yield return new WaitForSeconds(delay);

        //run function
        DisableLocationUpdateAnim();
    }

    public void DisableLocationUpdateAnim()
    {
        locationUpdateAnimator.SetBool("isTriggered", false);
    }
}
