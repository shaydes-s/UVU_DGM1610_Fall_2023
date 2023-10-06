using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveForward : MonoBehaviour
{
    [SerializeField] public float speed = 50f;
    // Update is called once per frame
    void Update()
    {
        //moves it forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
