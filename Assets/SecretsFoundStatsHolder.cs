using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecretsFoundStatsHolder : MonoBehaviour
{
    public int SecretsMax;
    public int SecretsCur;
    public Text SecretsUpdateText;
    public float delay;

    public void Start()
    {
        SecretsMax = SecretsMax;
        SecretsCur = 0;

        SecretsUpdateText.gameObject.SetActive(false);
    }

    public void Update()
    {
        
    }

    public void FoundNewSecret()
    {
        SecretsCur = SecretsCur + 1;
        SecretsUpdateText.text = "Secret Found\n" + SecretsCur + " / " + SecretsMax;
        SecretsUpdateText.gameObject.SetActive(true);
        StartCoroutine(DisplaySecretText(SecretsUpdateText.gameObject, delay));
    }

    public void HideSecretText ()
    {
        SecretsUpdateText.gameObject.SetActive(false);
    }

    private IEnumerator DisplaySecretText(GameObject text, float delay)
    {
        yield return new WaitForSeconds(delay);

        HideSecretText();
    }
}
