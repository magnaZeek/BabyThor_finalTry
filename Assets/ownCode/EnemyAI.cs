using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using System.Threading;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Seeker))]
public class enemyAI : MonoBehaviour
{
    //Chasing target
    public Transform target;

    //ai behaviour related variables
    public float speed = 200f;
    public float nextWaypointDistance = 3f;

    //pathrelated variables
    Path path;
    int currentWaypoint = 0;

    Seeker seeker;
    Rigidbody2D rb;

    //where does it look
    private Vector3 direction;
    //looking at target?
    private bool isFacingTarget;

    void Start()
    {
        seeker = GetComponent<seeker>();
        rb = GetComponent<Rigidbody2D>();

        seeker.StartPath(rb.position, target.position, OnPathComplete);

    }

    void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            currentWaypoint = 0;
        }
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (path = null)
        {
            
            return;
        }
           

        if (currentWaypoint >= path.vectorPath.Count)
        {
            reachedEndOfPath = true;
            return;
        }
        else
        {
            reachedEndOfPath = false;
        }

        Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - rb.position).nomralized;
        //Vector2 force = direction * speed * Timeout.deltaTime;

        rb.AddForce(force);

        float distance = Vector2.Distance(rb.position, path.vectorPath[currentWaypoint]);

        if (distance < nextWaypointDistance)
        {
            currentWaypoint++;
        }
    }

    private void rotateSprite()
    {
        direction = target.position - transform.position;
        if (direction.x > 0 && !isFacingTarget || direction.x < 0 && isFacingTarget)
        {
            isFacingTarget = !isFacingTarget;

            Vector2 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;

        }
    }


}

