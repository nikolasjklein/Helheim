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

    [Header("Thrall Animator")]
    [Tooltip("The Animator which contains the Animation States for the Thrall Enemy")]
    public Animator t_Anim;

    [Header("Look Radius")]
    [Tooltip("The radius in which the enemy can see the Player and starts chasing him")]
    [Range(.5f, 5f)]
    public float lr = 3f;

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

        if (distance <= lr)
        {
            agent.SetDestination(target.position);
            currentState = Thrall_States.Walk;

            if (distance <= agent.stoppingDistance)
            {
                FaceTarget();
                currentState = Thrall_States.Idle;
            }
        }

        else
        {
            currentState = Thrall_States.Idle;
        }

        if (currentState == Thrall_States.Idle)
        {
            t_Anim.SetBool("isWalking", false);
        }

        else if (currentState == Thrall_States.Walk)
        {
            t_Anim.SetBool("isWalking", true);
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
        Gizmos.DrawWireSphere(transform.position, lr);
    }
}
