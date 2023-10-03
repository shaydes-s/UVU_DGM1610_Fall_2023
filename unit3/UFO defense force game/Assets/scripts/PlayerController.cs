using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 50;
    public float xRange = 39;
    public Transform blaster;
    public GameObject lazer;

    // Update is called once per frame
    void Update()
    {
        //horizontal input
        horizontalInput = Input.GetAxis("Horizontal");
        //moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //keep player within bounds left side
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //right side
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //if space bar is pressed, fire lazer
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //creates lazer at blaster transform position
            Instantiate(lazer, blaster.position, lazer.transform.rotation);
        }

    }
        //delete objects it collides with
        private void OnTriggerEnter(Collider other)
        {
            Destroy(other.gameObject);
        }
}
