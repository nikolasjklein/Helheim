using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public PlayerController playerController;

    public float attackRadius = 1f;
    public float delay = 2f;

    public int enemyDamage = 5;

    public bool boolName;

    Transform target;
    NavMeshAgent agent;

    public void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    public void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= attackRadius)
        {
            agent.SetDestination(target.position);

            if (distance <= agent.stoppingDistance && !boolName)
            {
                StartCoroutine(attackPlayer(target.gameObject, delay));
                boolName = true;
            }
        }
    }

    public void AttackPlayer()
    {
        playerController.playerLife -= enemyDamage;
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
        Gizmos.DrawWireSphere(transform.position, attackRadius);
    }
}