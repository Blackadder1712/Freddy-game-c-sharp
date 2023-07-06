using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //restarting/loading scene

public class Scorer : MonoBehaviour
{
    [SerializeField] float levelLoadDelay;
    
      AudioSource dead;
     [SerializeField]  AudioClip jump;
      AudioSource scare;
       
     AudioSource crash;
     AudioClip ouch;
    [SerializeField] ParticleSystem ExplodeParticles; //explosion effects 
     [SerializeField] ParticleSystem BigExplodeParticles; //explosion effects 
    int hits = 0; //hold number of hits 
      bool collisionDisable = false; // turn collidors on and off 

    void Start()
    {
      crash = GetComponent<AudioSource>();
       dead = GetComponent<AudioSource>();   
       scare =GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Untagged" && !collisionDisable) //|| collisionDisable)
        {    
         hit();

        }
      
    

        if(hits >= 5)
        {
             StartCrashSequence();// 1 sec delay
           
        }
    }

    void hit() 
    {
          hits++; //each hit adds 1 to variable 
            Debug.Log("You've Crashed this many times:" + hits);//display value 
              ExplodeParticles.Play();    
              
            if(!crash.isPlaying)
            {
                crash.Play();
            }       
    }

        void RestartLevel()//reloads level on fail 
    {
        
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//return index of current scene
    }

        void StartCrashSequence()
    {
       scare.PlayOneShot(jump);
         BigExplodeParticles.Play();
        GetComponent<mover>().enabled = false;//remove control
         Invoke("RestartLevel", levelLoadDelay);

    }

    void Update()
    {
       
        if(Input.GetKeyDown(KeyCode.C))
        {
                collisionDisable = !collisionDisable; //toggle collision
        }

    }

}
