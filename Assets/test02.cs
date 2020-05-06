using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waking_Enemy : MonoBehaviour
{


    // GameObjects
    public Transform player;
    private BoxCollider2D boxCollider2d;
    private Rigidbody2D rb2d;
    public GameObject walker;

    //Movement Variables
    private int HP;
    public float moveSpeed;
    private bool isFlippedRight;
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {

        rb2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();

        HP = 2;
        isFlippedRight = true;
    }

    // Update is called once per frame
    void Update()
    {

        direction = player.position - transform.position;
        direction.Normalize();
        moveCharacter(direction);
        Flip(direction.x);

        if (HP <= 0) Destroy(walker);

    }

    //Flip Character

    private void Flip(float directionX)
    {

        if (directionX > 0 && !isFlippedRight || directionX < 0 && isFlippedRight)
        {
            isFlippedRight = !isFlippedRight;

            Vector2 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;

        }

    }

    private void moveCharacter(Vector2 direction)
    {

        rb2d.velocity = new Vector2(direction.x * moveSpeed, rb2d.velocity.y);

    }

    public void Damage(int damage)
    {

        HP -= damage;

    }
}
