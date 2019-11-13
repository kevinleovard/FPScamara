using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSmove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
public float speed = 0.1f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward*speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward*speed;            
        }
         if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right*speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right*speed;            
        }
        if(Input.GetKey(KeyCode.Space))
        {
            transform.position += transform.up*speed;

        }
    }
}
