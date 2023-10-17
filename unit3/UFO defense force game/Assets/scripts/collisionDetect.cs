using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetect : MonoBehaviour
{
    public ScoreManager scoreManager;
    public int scoreToGive;
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(scoreToGive);
        if(other.gameObject.tag == "bullet")
        {
            Destroy(gameObject); //destroy this game object
            Destroy(other.gameObject); //destroy game object it hits
        }
    }
}
