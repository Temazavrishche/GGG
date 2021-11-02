using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.AI;

public class Spear : MonoBehaviour
{
    private Vector3 startPosition;
    private float maxRange = 50,duration = 5, rotationSpeed = 1000;
    private GameObject Player;
    private List<GameObject> Enemy = new List<GameObject>();
    private bool stuck, hasEnemy;
    private GameObject StuckPos;
    public string[] tagsToChek,stuckTagsToCheck;
    public float SpearDamage;
    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Physics.IgnoreCollision(Player.GetComponent<CharacterController>(), GetComponent<Collider>());
    }
    private void Start()
    {
        startPosition = transform.position;
    }
    private void Update()
    {
        if (!stuck)
        {
            transform.position = transform.position + transform.up * 40 * Time.deltaTime;
            if (Enemy.Count != 0)
            {
                Vector3 enemyPos = StuckPos.transform.position;
                foreach (GameObject obj in Enemy)
                {
                    if(obj != null)
                        obj.transform.position = enemyPos;
                }
            }
            else transform.RotateAround(transform.position,transform.up,rotationSpeed * Time.deltaTime);
        }
        else
        {
            duration -= Time.deltaTime;
            if (duration < 0)
            {
                Destroy(gameObject);
            }
        }
        float dist = Vector3.Distance(startPosition, transform.position);
        if(dist > maxRange)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(!stuck && stuckTagsToCheck.Contains(other.tag))
        {
            stuck = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!stuck)
        {
            if (tagsToChek.Contains(other.tag) && !hasEnemy)
            {
                StuckPos = new GameObject("StuckPosition");
                StuckPos.transform.position = other.transform.position;
                StuckPos.transform.SetParent(transform);
                hasEnemy = true;
                AddEnemy(other);
            }
            else if (other.CompareTag("Enemy"))
            {
                AddEnemy(other);
            }
        }
    }
    private void OnDestroy()
    {
        if(Enemy.Count != 0)
        {
            foreach (GameObject obj in Enemy)
            {
                if(obj != null)
                {
                    if (obj.GetComponent<NavMeshAgent>() != null && obj.GetComponent<EnemyNavigation>() != null)
                    {
                        ComponenEnable(obj,true);
                    }
                }
            }
        }
    }
    private void AddEnemy(Collider other)
    {
        Enemy.Add(other.gameObject);
        if (other.GetComponent<NavMeshAgent>() != null && other.GetComponent<EnemyNavigation>() != null)
        {
            ComponenEnable(other.gameObject, false);
        }
        if(other!= null)
            other.GetComponent<EnemyHealth>().TakeDamage(SpearDamage);
    }

    private void ComponenEnable(GameObject obj,bool ChangeBool)
    {
        obj.GetComponent<NavMeshAgent>().enabled = ChangeBool;
        obj.GetComponent<EnemyNavigation>().enabled = ChangeBool;
    }
}
