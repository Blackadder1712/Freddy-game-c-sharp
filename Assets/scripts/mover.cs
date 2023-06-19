using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
   public GameObject player;
  float moveSpeed = 10f;
  float nitro = 15f;
  [SerializeField] float mainThrust = 100f;
  
  Rigidbody rb;
  
  AudioSource crash;
   

    void Start()
    {
        rb = GetComponent<Rigidbody>();    
        PrintInstructions();//not passing arguments 
  
        player = GameObject.Find("Player");
        crash = GetComponent<AudioSource>();
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

        private void OnCollisionEnter(Collision other) 
    {
        //change to red on collision 
        if(other.gameObject.tag == "Untagged" )
        {
        player.GetComponent<MeshRenderer>().material.color = Color.red;
       
        
            if(!crash.isPlaying)
            {
                crash.Play();
            }       
                 
        }
        else
        {
            crash.Stop();
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
