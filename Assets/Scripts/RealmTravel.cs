using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RealmTravel : MonoBehaviour
{
    public int index;

    public Text indexText;
    public Text realmText;

    public Image muspelheimSprite;
    public Image alfheimSprite;
    public Image vanaheimSprite;
    public Image midgardSprite;
    public Image asgardSprite;
    public Image jotunheimSprite;
    public Image nidavellirSprite;
    public Image svartalfheimSprite;
    public Image niflheimSprite;

    public enum Realms
    {
        Muspelheim,
        Alfheim,
        Vanaheim,
        Midgard,
        Asgard,
        Jotunheim,
        Nidavellir,
        Svartalheim,
        Niflheim
    }

    public Realms currentRealm = Realms.Muspelheim;

    public static WeaponSwitch Instance;

    public Realms CurrentRealm
    {
        get
        {
            return currentRealm;
        }
    }

    public void Start()
    {
        currentRealm = Realms.Muspelheim;
    }

    public void Update()
    {
        indexText.text = index.ToString();

        if (Input.GetKeyDown(KeyCode.Q))
        {
            index = index-1;

            if (index < 1)
            {
                index = 9;
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            index = index + 1;

            if (index > 9)
            {
                index = 1;
            }
        }

        if (index == 1)
        {
            currentRealm = Realms.Muspelheim;
            realmText.text = currentRealm.ToString();

            muspelheimSprite.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
            alfheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            vanaheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            midgardSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            asgardSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            jotunheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            nidavellirSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            svartalfheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            niflheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
        }

        if (index == 2)
        {
            currentRealm = Realms.Alfheim;
            realmText.text = currentRealm.ToString();

            muspelheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            alfheimSprite.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
            vanaheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            midgardSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            asgardSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            jotunheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            nidavellirSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            svartalfheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            niflheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
        }

        if (index == 3)
        {
            currentRealm = Realms.Vanaheim;
            realmText.text = currentRealm.ToString();

            muspelheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            alfheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            vanaheimSprite.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
            midgardSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            asgardSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            jotunheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            nidavellirSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            svartalfheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            niflheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
        }

        if (index == 4)
        {
            currentRealm = Realms.Midgard;
            realmText.text = currentRealm.ToString();

            muspelheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            alfheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            vanaheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            midgardSprite.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
            asgardSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            jotunheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            nidavellirSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            svartalfheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            niflheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
        }

        if (index == 5)
        {
            currentRealm = Realms.Asgard;
            realmText.text = currentRealm.ToString();

            muspelheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            alfheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            vanaheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            midgardSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            asgardSprite.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
            jotunheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            nidavellirSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            svartalfheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            niflheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
        }

        if (index == 6)
        {
            currentRealm = Realms.Jotunheim;
            realmText.text = currentRealm.ToString();

            muspelheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            alfheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            vanaheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            midgardSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            asgardSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            jotunheimSprite.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
            nidavellirSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            svartalfheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            niflheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
        }

        if (index == 7)
        {
            currentRealm = Realms.Nidavellir;
            realmText.text = currentRealm.ToString();

            muspelheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            alfheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            vanaheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            midgardSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            asgardSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            jotunheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            nidavellirSprite.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
            svartalfheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            niflheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
        }

        if (index == 8)
        {
            currentRealm = Realms.Svartalheim;
            realmText.text = currentRealm.ToString();

            muspelheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            alfheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            vanaheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            midgardSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            asgardSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            jotunheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            nidavellirSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            svartalfheimSprite.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
            niflheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
        }

        if (index == 9)
        {
            currentRealm = Realms.Niflheim;
            realmText.text = currentRealm.ToString();

            muspelheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            alfheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            vanaheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            midgardSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            asgardSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            jotunheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            nidavellirSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            svartalfheimSprite.transform.localScale = new Vector3(0.11f, 0.11f, 0.11f);
            niflheimSprite.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
        }
    }
}
