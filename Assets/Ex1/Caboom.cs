using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Caboom : MonoBehaviour
{
    [SerializeField] float radius;
    [SerializeField] LayerMask layerM;

    void Start()
    {
        
    }


    void Update()
    {
        Collider[] colls = Physics.OverlapSphere(transform.position, radius, layerM);

        foreach (Collider coll in colls)
        {
            Rigidbody rb = coll.GetComponent<Rigidbody>();
    
        rb.AddForce(Vector3.up * 2, ForceMode.Impulse); // Подбрасываем вверх
    
        }
    }
}
