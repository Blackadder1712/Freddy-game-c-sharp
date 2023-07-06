using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public Transform myGameObjectTransform;
    public float zAngle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      
        rotate();

        void rotate()
            {
              
                Controls();
                           
            }

            void Controls() //face correct way
            {
                   if(Input.GetKeyDown(KeyCode.D))
                {
                right();
                }

                if(Input.GetKeyDown(KeyCode.A))
                {
                left();
                }

                  if(Input.GetKeyDown(KeyCode.W))
                {
                forward();
                }  

                  if(Input.GetKeyDown(KeyCode.S))
                {
                back();
                }
              
            }

            void right()
            {
                this.transform.rotation = Quaternion.Euler(-90,0,90);
            }

            void left()
            {
               this.transform.rotation = Quaternion.Euler(-90,0,-90);
            }

            void forward()
            {
                 this.transform.rotation = Quaternion.Euler(-90,0,0);
            }

            void back()
            {
                this.transform.rotation = Quaternion.Euler(-90,0,180);
            }
    }
}
