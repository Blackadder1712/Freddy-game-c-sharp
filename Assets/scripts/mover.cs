using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
 
  [SerializeField] float moveSpeed = 10f;
   

    void Start()
    {
        PrintInstructions();//not passing arguments 
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
       
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


  

    

    
}
