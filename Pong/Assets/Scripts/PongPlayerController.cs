using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongPlayerController : MonoBehaviour
{
    private Vector3 moveDirection = Vector3.zero;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.0f;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX;
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = new Vector3(0.0f, Input.GetAxis("Vertical") * 10.0f, 0.0f);
        rb.velocity = moveDirection;
    }
}
