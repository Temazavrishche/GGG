using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavigation : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject target;
    private Animator anim;
    private void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Base");
        agent.SetDestination(target.transform.position);
        anim.SetBool("Idle", false);
    }
    private void OnDisable()
    {
        anim.SetBool("Idle",true);
    }
    private void Update()
    {
        float dist = Vector3.Distance(transform.position,target.transform.position);
        if(dist <= 8)
        {
            agent.isStopped = true;
            anim.SetBool("Attack",true);
        }
        else
        {
            anim.SetBool("Attack", false);
            agent.isStopped = false;
        }
    }
}
