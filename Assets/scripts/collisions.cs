
using UnityEngine;
using UnityEngine.SceneManagement; //restarting/loading scene

public class collisions : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 2f;
    [SerializeField] AudioClip win;
   
     AudioSource complete;
    
    
    void Start()
    {
        complete = GetComponent<AudioSource>();   
      
    }


    void OnCollisionEnter(Collision other) 
    {
        Debug.Log("done");
        switch (other.gameObject.tag)
        {
           
            case "Finish":
                Debug.Log("You Win!");
                 StartNextSequence();// 1 sec delay
                break;
            default:
                Debug.Log("Try not to get hit!");
                break;
        }
    }

    
  
    void NextLevel()
    {
         int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
         int nextSceneIndex = currentSceneIndex + 1;
         if(nextSceneIndex == SceneManager.sceneCountInBuildSettings)//loop through levels 
         {
            nextSceneIndex = 0;
         }

         SceneManager.LoadScene(nextSceneIndex); //load first level

    }

      void StartNextSequence()// 1 sec delay
     {
        complete.PlayOneShot(win);
        GetComponent<mover>().enabled = false;
        Invoke("NextLevel", levelLoadDelay);
     }
}


