using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GrapplingHook : MonoBehaviour
{
    public float speed, grapplinSpeed, range, stopRange,duration;
    private LineRenderer line;
    public Transform caster, chainPoint;
    private bool hasCollided;
    private Vector3 startPos;
    public string[] tagsToChek;
    private void Awake()
    {
        caster = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void Start()
    {
        line = transform.Find("Line").GetComponent<LineRenderer>();
        startPos = transform.position;
    }
    private void Update()
    {
        float dist = Vector3.Distance(startPos,transform.position);
        float distance = Vector3.Distance(caster.position,transform.position);
        if(distance < stopRange && hasCollided)
        {
            Destroy(gameObject);
        }
        if(dist > range)
        {
            Destroy(gameObject);
        }
        if (!hasCollided)
        {
            transform.position = transform.position + transform.forward * speed * Time.deltaTime;
        }
        else
        {
            duration -= Time.deltaTime;
            caster.LookAt(transform);
            caster.position = caster.position + caster.forward * grapplinSpeed * Time.deltaTime;
        }
        if(duration <= 0)
        {
            Destroy(gameObject);
        }
        if (caster)
        {
            line.SetPosition(0, caster.position);
            line.SetPosition(1, chainPoint.position);
        }
        else Destroy(gameObject);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (tagsToChek.Contains(other.tag) && !hasCollided)
        {
            caster.GetComponent<PlayerGravity>().enabled = false;
            caster.GetComponent<PlayerMove>().enabled = false;
            hasCollided = true;
        }
    }
    private void OnDestroy()
    {
        if (caster.GetComponent<PlayerMove>().enabled == false || caster.GetComponent<PlayerGravity>().enabled == false)
        {
            caster.GetComponent<PlayerGravity>().enabled = true;
            caster.GetComponent<PlayerMove>().enabled = true;
        }
    }
}
