
using UnityEngine;

public class collisions : MonoBehaviour
{

    void OnCollisionEnter(Collision other) 
    {
        Debug.Log("done");
        switch (other.gameObject.tag)
        {
            case "hit":
                Debug.Log("You hit the wall");
                break;
            case "Finish":
                Debug.Log("You Win!");
                break;
            default:
                Debug.Log("Try not to get hit!");
                break;
        }
    }
}


