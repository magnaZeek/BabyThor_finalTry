using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    //variables
    public Transform player;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z); 

    }

    private void FixedUpdate()
    {

        // Camera follows the player with specified offset position
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);

    }
}
