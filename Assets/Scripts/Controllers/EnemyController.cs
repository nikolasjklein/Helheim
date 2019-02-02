using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    /*
     animStates:
     1  -   Idle
     2  -   Walk
     3  -   Charge
     4  -   Attack
     5  -   Die
     6  -   Death
     */

    public enum Thrall_States
    {
        Idle,
        Walk,
        Charge,
        Attack,
        Die,
        Death
    }

    public Enemy enemy;

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
        Debug.Log(currentState.ToString());

        float distance = Vector3.Distance(target.position, transform.position);

        if (distance >= lr && !enemy.isAttacking)
        {
            currentState = Thrall_States.Idle;
        }

        if (distance <= lr && !enemy.isAttacking)
        {
            agent.SetDestination(target.position);
            currentState = Thrall_States.Walk;

            if (distance <= agent.stoppingDistance && !enemy.isAttacking)
            {
                FaceTarget();
                currentState = Thrall_States.Idle;
            }
        }

        else if (distance <= agent.stoppingDistance && enemy.isAttacking)
        {
            currentState = Thrall_States.Charge;
        }

        ///////////////////////////////////////////////////////////
        if (currentState == Thrall_States.Idle)
        {
            t_Anim.SetInteger("animState", 1);
        }

        ///////////////////////////////////////////////////////////
        if (currentState == Thrall_States.Walk)
        {
            t_Anim.SetInteger("animState", 2);
        }

        ///////////////////////////////////////////////////////////
        if (currentState == Thrall_States.Charge)
        {
            t_Anim.SetInteger("animState", 3);
        }

        ///////////////////////////////////////////////////////////
        if (currentState == Thrall_States.Attack)
        {
            t_Anim.SetInteger("animState", 4);
        }

        ///////////////////////////////////////////////////////////
        if (currentState == Thrall_States.Die)
        {
            t_Anim.SetInteger("animState", 5);
        }

        if (enemy.isDead)
        {
            currentState = Thrall_States.Die;
            lr = 0f;
            this.GetComponent<NavMeshAgent>().speed = 0f;
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
