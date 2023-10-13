using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetect : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "bullet")
        {
            Destroy(gameObject); //destroy this game object
            Destroy(other.gameObject); //destroy game object it hits
        }
    }
}
