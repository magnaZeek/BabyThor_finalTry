using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike : MonoBehaviour
{
    float startX;
    float startY;
    float startX2;
    float startY2;
    public Transform player01;
    public Transform player02;
    // Start is called before the first frame update
    void Start()
    {

        startX = player01.transform.position.x;
        startY = player01.transform.position.y;
        startX2 = player02.transform.position.x;
        startY2 = player02.transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "player01")
        {
            player01.position = new Vector3(startX, startY, transform.position.z);
        }
        if (collision.gameObject.name == "player02")
        {
            player02.position = new Vector3(startX2, startY2, transform.position.z);
        }


    }
}
