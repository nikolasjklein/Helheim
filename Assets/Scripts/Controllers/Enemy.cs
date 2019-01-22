using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [Header("Player Controller")]
    [Tooltip("The GameObject which contains the Character Controller - Script")]
    public PlayerController pCont;

    [Header("Attack Radius")]
    [Tooltip("The radius in which the enemy will start an attack")]
    [Range(.1f, 2f)]
    public float ar = 1f; //radius in which the enemy can attack
    [Header("Damage Radius")]
    [Tooltip("The radius in which the enemy will do damage to the player")]
    [Range(.1f, 2f)]
    public float dr = 1f; //this is so that he attacks if you are inside the attackRadius but take damage when within the damageRadius
    [Header("Attack Casting Delay")]
    [Tooltip("The delay the enemy waits for before casting another attack")]
    public float delay = 2f; //delay the enemy has between attacks
    [Header("Enemy Health")]
    [Tooltip("The health of the enemy")]
    public int health = 5; //enemy health
    [Header("Enemy Damage")]
    [Tooltip("The damage the enemy does per attack, duh!")]
    public int enemyDamage = 5;

    private bool boolName;

    Transform target;
    NavMeshAgent agent;

    public void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    public void Update()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }

        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= ar)
        {
            agent.SetDestination(target.position);

            if (distance <= agent.stoppingDistance && !boolName)
            {
                AttackPlayer();
            }
        }
    }

    public void AttackPlayer()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= ar)
        {
            if (boolName == false)
            {
                pCont.GetComponent<AudioSource>().Play(0);
                pCont.playerLife -= enemyDamage;
                StartCoroutine(attackPlayer(target.gameObject, delay));
                boolName = true;
            }
        }
    }

    private IEnumerator attackPlayer(GameObject target, float delay)
    {
        yield return new WaitForSeconds(delay);

        AttackPlayer();

        boolName = false;
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, ar);
        Gizmos.DrawWireSphere(transform.position, dr);
    }
}