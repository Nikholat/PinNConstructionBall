using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickExplosion : MonoBehaviour
{
    [SerializeField] Transform bench;
    [SerializeField] GameObject button; 
    [SerializeField] GameObject canvas; 
    private float timer = 0f;
    private bool isTiming = false; 

     void Update()
    {
        if (isTiming)
        {
            timer += Time.deltaTime; 

            if (timer >= 0.8f)
            {
                DisableCanvas(); 
                isTiming = false; 
            }
        }
    }

    private void DisableCanvas()
    {
        if (canvas != null)
        {
            canvas.SetActive(false); 
        }
    }

    public void DisableKinematicOnBench()
    {
        if (bench != null)
        {
            foreach (Transform child in bench)
            {
                Rigidbody rb = child.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.isKinematic = false;
                }
            }
        }
        button.SetActive(false);
        isTiming = true; 
        timer = 0f;
    }
}

