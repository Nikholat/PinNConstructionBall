using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceUp : MonoBehaviour
{
    [SerializeField] SoundManager soundManager;
    private Rigidbody rb;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        LeftMouseCheck();
        RightMouseCheck();
    }

    private void LeftMouseCheck()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if( gameObject.CompareTag("LeftPin"))
            rb.AddForce(0, 10, 0, ForceMode.Impulse);
            soundManager.PlayLeftClickSound();
        }
    }

    private void RightMouseCheck()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if( gameObject.CompareTag("RightPin"))
            rb.AddForce(0, 10, 0, ForceMode.Impulse);
            soundManager.PlayRightClickSound();
        }
    }
}
