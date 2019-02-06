using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Homebrew;

public class TriggerLocationUpdate : MonoBehaviour
{
    [Foldout("Technical Vars - no touchy if no needy to")]
    [Header("Location Update Animator")]
    [Tooltip("The Animator which holds the animation for this pop-up")]
    public Animator locationUpdateAnimator;

    [Foldout("Technical Vars - no touchy if no needy to")]
    [Header("Location Update Text")]
    [Tooltip("The Text on which the new Location is displayed")]
    public Text locationUpdateText;

    [Header("Location Name")]
    [Tooltip("The Name which will be displayed when walking into the trigger")]
    public string locationName;

    [Header("Location Update Deration (in Seconds)")]
    [Tooltip("The Amount of Time in which the Location Text will be displayed (in seconds)")]
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
