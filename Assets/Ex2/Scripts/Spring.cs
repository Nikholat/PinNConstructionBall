using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    [SerializeField] SoundManager soundManager;
    private bool isSpacePressed = false;
    private Rigidbody rb;
    private float targetY = 2.03f;
    private float lerpSpeed = 3.0f;
   

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        SpacePress();
    }

    private void FixedUpdate() 
    {
        if (isSpacePressed)
        {
            Vector3 currentPosition = transform.position;
            float newY = Mathf.Lerp(currentPosition.y, targetY, lerpSpeed * Time.deltaTime);
            rb.MovePosition(new Vector3(currentPosition.x, newY, currentPosition.z));
        }
    }

    private void SpacePress()
    {
        if (Input.GetKeyDown("space"))
        {
            isSpacePressed = true;
            rb.isKinematic = true;
        }
      
        if (Input.GetKeyUp("space"))
        {
            isSpacePressed = false;
            rb.isKinematic = false;
            soundManager.PlaySpacebarSound();
        }
    }
}
