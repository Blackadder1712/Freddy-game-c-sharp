using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driving : MonoBehaviour
{

    [SerializeField] AudioClip driven;
    AudioSource drive;
    // Start is called before the first frame update
    void Start()
    {
            drive = GetComponent<AudioSource>();  
    }



    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
           

            if(!drive.isPlaying)
            {
                drive.PlayOneShot(driven);
            
            }    
            
                 

        }
        else
        {
            drive.Stop();
        }
    }
}
