using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressurePlate : MonoBehaviour
{

    bool pressed = false;
    public Transform connectedBlock;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pressed == true)
        {
            //GetComponent<Animation>().Play("pressurePlateDown");
            //Debug.Log(pressed);
        }
        if (pressed == false)
        {
            //GetComponent<Animation>().Play("pressurePlateUp");
            //Debug.Log(pressed);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter function called");
        connectedBlock.position = new Vector3(connectedBlock.position.x, connectedBlock.position.y-0.5f, transform.position.z);
        Debug.Log(connectedBlock.position.x);
    } 

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Enter function called");
        connectedBlock.position = new Vector3(connectedBlock.position.x, connectedBlock.position.y + 0.5f, transform.position.z);
        Debug.Log(connectedBlock.position.x);
    }


}
