using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public enum Thrall_States
    {
        Idle,
        Walk
    }

    public Animator Thrall_Animator;

    public float lookRadius = 2.5f;

    Transform target;
    NavMeshAgent agent;

    public Thrall_States currentState = Thrall_States.Idle;

    public Thrall_States CurrentState
    {
        get
        {
            return currentState;
        }
    }

    public void Start()
    {
        currentState = Thrall_States.Idle;

        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    public void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);
            currentState = Thrall_States.Walk;

            if (distance <= agent.stoppingDistance)
            {
                FaceTarget();
            }
        }

        else
        {
            currentState = Thrall_States.Idle;
        }

        if (currentState == Thrall_States.Idle)
        {
            Thrall_Animator.SetBool("isWalking", false);
        }

        else if (currentState == Thrall_States.Walk)
        {
            Thrall_Animator.SetBool("isWalking", true);
        }
    }

    public void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
