using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ArcLightning : MonoBehaviour
{
    public float speed, maxTarget, ArcDamage,range;
    public int currentNumberOfTargets = 0;
    private LineRenderer line;
    public Transform caster;
    public string[] tagsToChek;
    public LayerMask mask;
    private GameObject target = null;
    public string _DamagedTargets;
    private void Awake()
    {
        caster = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Start()
    {
        line = transform.Find("ArcLine").GetComponent<LineRenderer>();
        line.SetPosition(0, caster.transform.position);
        UpdateTarget();
    }

    private void Update()
    {
        Debug.Log(_DamagedTargets);
        if (target != null)
        {
            transform.LookAt(target.transform);
            Vector3 dir = target.transform.position - transform.position;
            float distanceThisFrame = speed * Time.deltaTime;
            if (dir.magnitude <= distanceThisFrame && target!= null)
            {
                target.GetComponent<EnemyHealth>().TakeDamage(ArcDamage);
                _DamagedTargets += target.name + " ";
                target = null;
            }
            transform.Translate(dir.normalized * distanceThisFrame,Space.World);
        }
        else
        {
            if (currentNumberOfTargets < maxTarget)
                UpdateTarget();
            else Destroy(gameObject);
        }
        if(line.transform.position == Vector3.zero)
        {
            Destroy(gameObject);
        }
    }
    private void UpdateTarget()
    {
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        Collider[] Cols = Physics.OverlapSphere(transform.position, range, mask);
        foreach(Collider col in Cols)
        {
            if (!_DamagedTargets.Contains(col.name))
            {
                float distToEnemy = Mathf.Infinity;
                distToEnemy = Vector3.Distance(transform.position, col.transform.position);
                if (distToEnemy < shortestDistance)
                {
                    shortestDistance = distToEnemy;
                    nearestEnemy = col.gameObject;
                }
            }
        }
        if (nearestEnemy != null)
        {
            target = nearestEnemy;
        }
        else target = null;
        addLine();
        currentNumberOfTargets++;
    }
    private void addLine()
    {
        if (target != null)
        {
            line.positionCount = currentNumberOfTargets + 2;
            line.SetPosition(currentNumberOfTargets + 1, target.transform.position + Vector3.up);
        }
        else Destroy(gameObject);
    }
}
