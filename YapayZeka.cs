using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class YapayZeka : MonoBehaviour
{

    NavMeshAgent ajan;
    [SerializeField] GameObject hedef;

    void Start()
    {
        ajan = GetComponent<NavMeshAgent>();
        ajan.SetDestination(hedef.transform.position);
    }


    void Update()
    {
        ajan.SetDestination(hedef.transform.position);
    }
}
