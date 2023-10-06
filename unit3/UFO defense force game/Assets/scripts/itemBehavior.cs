using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBehavior : MonoBehaviour
{   
    private int itemCount = 0;
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("item"))
        {
            itemCount++;
            Debug.Log("Item Count = " + itemCount);
            Destroy(collider.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
