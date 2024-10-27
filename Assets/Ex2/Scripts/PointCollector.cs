using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCollector : MonoBehaviour
{
    [SerializeField] private LayerMask layer;
    [SerializeField] SoundManager soundManager;
    private float radius = 0.1f;
    
    void Update()
    {
        PointRemove();
    }

    private void PointRemove()
    {
        Collider[] colls = Physics.OverlapSphere(transform.position, radius, layer);

        foreach (Collider coll in colls)
        {
            Destroy(coll.gameObject);
            soundManager.PlayCoinCollectSound();
        }
    }
}
