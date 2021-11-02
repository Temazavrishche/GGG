using UnityEngine.AI;
using UnityEngine;
using System.Linq;

public class VacuumGrenade : MonoBehaviour
{
    public string[] tagsToCheck;
    public LayerMask mask;
    public float radius, vacuumSpeed, duration;
    private bool stuck;
    private void Update()
    {
        if(!stuck)
            transform.position = transform.position + transform.forward * 25 * Time.deltaTime;
        else
            vacuum();
        duration -= Time.deltaTime;
        if(duration <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (tagsToCheck.Contains(other.tag))
        {
            stuck = true;
        }
    }
    private void vacuum()
    {
        Collider[] Cols = Physics.OverlapSphere(transform.position, radius, mask);
        foreach (Collider col in Cols)
        {
            ComponenEnable(col.gameObject,false);
            col.gameObject.transform.position = Vector3.Lerp(col.gameObject.transform.position,transform.position,vacuumSpeed * Time.deltaTime);
        }
    }
    private void ComponenEnable(GameObject obj, bool ChangeBool)
    {
        obj.GetComponent<NavMeshAgent>().enabled = ChangeBool;
        obj.GetComponent<EnemyNavigation>().enabled = ChangeBool;
    }
    private void OnDestroy()
    {
        Collider[] Cols = Physics.OverlapSphere(transform.position, radius, mask);
        foreach (Collider col in Cols)
        {
            ComponenEnable(col.gameObject, true);
        }
    }
}
