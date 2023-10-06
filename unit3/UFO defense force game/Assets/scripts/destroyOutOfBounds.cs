using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.0f;
    public float lowerBounds = -30.0f;
    // Start is called before the first frame update
    void Awake()
    {
        //Time.timescale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds)
        {
            if(this.gameObject.tag != "item")
            {
            Debug.Log("Game Over");
            }
            Destroy(gameObject);
            //Time.timescale = 0;
        }
    }
}
