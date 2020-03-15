using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    public GameObject ballPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    public void LaunchBall()
    {
        GameObject ballObject = Instantiate<GameObject>(ballPrefab);
        ballObject.transform.position = transform.position;
        ballObject.tag = "Ball";
        Rigidbody2D rigidBody = ballObject.GetComponent<Rigidbody2D>();
        Vector3 direction = Random.Range(0, 2) == 1 ? Vector3.right : Vector3.left;
        Vector3 angle = Quaternion.AngleAxis(45.0f, Vector3.forward) * direction;
        rigidBody.AddForce(angle * 500.0f);
    }
}
