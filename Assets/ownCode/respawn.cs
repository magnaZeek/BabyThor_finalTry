using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public Transform player01;
    float horizontalMove = 0f;
    float startX, startY, currentY;

    // Start is called before the first frame update
    void Start()
    {
        startX = player01.transform.position.x;
        startY = player01.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        currentY = player01.transform.position.y;
        if (currentY <= -10)
        {
            player01.position = new Vector3(startX, startY, transform.position.z);
        }
    }
}
