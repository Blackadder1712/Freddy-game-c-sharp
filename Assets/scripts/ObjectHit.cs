using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    
  
    public GameObject player;
  
  

      void Start()
      {
         player = GameObject.Find("Player");
     
        
      }
  
    private void OnCollisionEnter(Collision other) 
    {
        //change to red on collision 
        if(other.gameObject.tag == "Player" && gameObject.tag =="Untagged")
        {
            
            gameObject.tag = "hit";
          
                 
        }
       
    }

    private void OnCollisionExit(Collision other) 
    {
         
    }

}
