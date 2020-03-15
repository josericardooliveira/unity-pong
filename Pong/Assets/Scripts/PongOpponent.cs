using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongOpponent : MonoBehaviour
{
    private Vector3 moveDirection = Vector3.zero;

    private Rigidbody2D rb;

    private BoxCollider2D collider;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        collider = gameObject.GetComponent<BoxCollider2D>();
        rb.gravityScale = 0.0f;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] balls = GameObject.FindGameObjectsWithTag("Ball");

        if(balls.Length > 0)
        {
            if(Vector2.Distance(balls[0].transform.position, transform.position) <= 3)
            {
                float boxSize = collider.bounds.size.y / 2.0f;
                boxSize *= balls[0].transform.position.y > 0 ? -1 : 1;
                boxSize *= Mathf.Abs(balls[0].transform.position.y) > collider.bounds.size.y ? 1 : 0;
                moveDirection = new Vector3(transform.position.x, balls[0].transform.position.y + boxSize, 0.0f);
                gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, moveDirection, Time.deltaTime * 10);
                //rb.velocity = moveDirection;
            }

        }
    }
}
