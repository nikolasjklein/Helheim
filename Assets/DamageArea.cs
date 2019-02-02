using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageArea : MonoBehaviour
{
    public Enemy enemy;
    public bool enemyIsInRange;

    public GameObject damageArea;

    public EnemyController enemyController;

    public GameObject player;
    private PlayerManager playManager;

    public void OnTriggerStay(Collider other)
    {
        if (enemy.isDead == true)
        {
            enemyIsInRange = false;
        }

        else if (enemy.isDead == false)
        {
            if (other.tag == "Player")
            {
                enemyIsInRange = true;
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enemyIsInRange = false;
        }
    }

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playManager = player.GetComponent<PlayerManager>();
    }

    public void Update()
    {
        //myMat.color = colMix;

        /*
        if (timer < 2)
        {
            timer += 1 * Time.deltaTime;
            if (timer > 1)
            {
                colMix = Color.Lerp(col1, col2, Mathf.PingPong(timer - 1, 1));
            }
        }
        */
    }
}
