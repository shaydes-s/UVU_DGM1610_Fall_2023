using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetect : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); //destroy this game object
        Destroy(other.gameObject); //destroy game object it hits
    }
}
