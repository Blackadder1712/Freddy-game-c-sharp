using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
 
  float moveSpeed = 10f;
  float nitro = 0f;
  
  Rigidbody rb;
   

    void Start()
    {
        rb = GetComponent<Rigidbody>();    
        PrintInstructions();//not passing arguments 
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        ProcessThrust();

        
        void ProcessThrust()
        {
            if(Input.GetKey(KeyCode.Space))
            {
               
              Speed();
            }
           
        }
       
    }

    void PrintInstructions()//no return or peram
    {
       Debug.Log("Welcome to the game");
       Debug.Log("move the car with WASD or arrows");
       Debug.Log("Dont get hit!");
    }

    void Movement()//player movement 
    {
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed; 
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;

        transform.Translate(xValue,0, zValue);        
         //move position with controller , framerate independent at selected speed
    }

    void Speed()
    {
         float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*nitro; 
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime*nitro;

        transform.Translate(xValue,0, zValue);        
         //move position with controller , framerate independent at selected speed

    }



  

    

    
}
