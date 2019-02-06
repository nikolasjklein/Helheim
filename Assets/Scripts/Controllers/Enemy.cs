using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public GameObject damageArea;
    public DamageArea damArea;

    public bool playAttackAnimation;

    public EnemyController enemyController;

    public bool isDead;

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
    public float delay = 5f; //delay the enemy has between attacks
    [Header("Enemy Health")]
    [Tooltip("The health of the enemy")]
    public int health = 5; //enemy health
    [Header("Enemy Damage")]
    [Tooltip("The damage the enemy does per attack, duh!")]
    public int enemyDamage = 5;

    public bool isAttacking;

    Transform target;
    NavMeshAgent agent;

    public void Start()
    {
        isDead = false;
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();

        playAttackAnimation = false;
    }

    public void Update()
    {
        if (health <= 0)
        {
            isDead = true;
        }

        if (isDead)
        {
            StartCoroutine(destroyThrall(5f));
            StartCoroutine(setThrallStateToDead(0.4f));
        }

        ///////////////////////////////////////////////////////////
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= ar)
        {
            agent.SetDestination(target.position);

            if (distance <= agent.stoppingDistance && !isAttacking)
            {
                AttackPlayer();
            }
        }

        if (playAttackAnimation)
        {
            enemyController.currentState = EnemyController.Thrall_States.Attack;
            enemyController.t_Anim.SetInteger("animState", 4);
        }
    }

    ///////////////////////////////////////////////////////////
    public void AttackPlayer()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= ar)
        {
            if (isAttacking == false)
            {
                isAttacking = true;
                StartCoroutine(attackPlayer());
            }
        }
    }

    //function to destroy the thrall enemy if dead (run by coroutine)
    public void DestroyThrall()
    {
        Destroy(this.gameObject);
    }

    //function to set the thrall enemy state to dead
    public void SetThrallStateToDead()
    {
        enemyController.currentState = EnemyController.Thrall_States.Death;
    }

    //coroutine for attacking the player
    private IEnumerator attackPlayer()
    {
        yield return new WaitForSeconds(1f);

        enemyController.currentState = EnemyController.Thrall_States.Charge;
        yield return new WaitForSeconds(1f);

        enemyController.currentState = EnemyController.Thrall_States.Attack;

        if (damArea.enemyIsInRange == true)
        {
            pCont.GetComponent<AudioSource>().Play(0);
            pCont.pL -= enemyDamage;

            isAttacking = false;
        }

        else
        {
            isAttacking = false;
        }

        AttackPlayer();
    }

    //coroutine for killing the thrall enemy
    private IEnumerator setThrallStateToDead(float delay)
    {
        yield return new WaitForSeconds(delay);

        SetThrallStateToDead();
    }

    //coroutine for destroying the thrall enemy
    private IEnumerator destroyThrall(float delay)
    {
        yield return new WaitForSeconds(delay);

        DestroyThrall();
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, ar);
        Gizmos.DrawWireSphere(transform.position, dr);
    }
}