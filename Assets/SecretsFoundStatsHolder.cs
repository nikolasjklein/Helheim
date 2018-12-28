using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecretsFoundStatsHolder : MonoBehaviour
{
    public int SecretsMax;
    public int SecretsCur;
    public string SecretsName;

    public Text SecretsUpdateText_1;
    public Text SecretsUpdateText_2;
    public Text SecretsUpdateText_3;
    public float delay;

    public void Start()
    {
        SecretsMax = SecretsMax;
        SecretsCur = 0;

        SecretsUpdateText_1.gameObject.SetActive(false);
        SecretsUpdateText_2.gameObject.SetActive(false);
        SecretsUpdateText_3.gameObject.SetActive(false);
    }

    public void Update()
    {
        
    }

    public void FoundNewSecret()
    {
        SecretsCur = SecretsCur + 1;
        SecretsUpdateText_1.text = "Secret Found";
        SecretsUpdateText_2.text = SecretsCur + " / " + SecretsMax;
        SecretsUpdateText_3.text = "'" + SecretsName + "'";

        SecretsUpdateText_1.gameObject.SetActive(true);
        SecretsUpdateText_2.gameObject.SetActive(true);
        SecretsUpdateText_3.gameObject.SetActive(true);

        StartCoroutine(DisplaySecretText(SecretsUpdateText_1.gameObject, SecretsUpdateText_2.gameObject, SecretsUpdateText_3.gameObject, delay));
    }

    public void HideSecretText ()
    {
        SecretsUpdateText_1.gameObject.SetActive(false);
        SecretsUpdateText_2.gameObject.SetActive(false);
        SecretsUpdateText_3.gameObject.SetActive(false);
    }

    private IEnumerator DisplaySecretText(GameObject text, GameObject text2, GameObject text3, float delay)
    {
        yield return new WaitForSeconds(delay);

        HideSecretText();
    }
}
