using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //restarting/loading scene

public class Scorer : MonoBehaviour
{
    int hits = 0; //hold number of hits 

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Untagged")
        {    hits++; //each hit adds 1 to variable 
            Debug.Log("You've Crashed this many times:" + hits);//display value 
        }

        if(hits >= 5)
        {
            RestartLevel();
        }
    }

        void RestartLevel()//reloads level on fail 
    {
        
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//return index of current scene
    }

}
