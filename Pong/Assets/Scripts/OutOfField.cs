using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfField : MonoBehaviour
{
    public bool IsHome;

    public GameState gameState;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ball")
        {
            Object.Destroy(other.gameObject);
            if(IsHome)
            {
                gameState.IncrementOpponentScore();
            }
            else
            {
                gameState.IncrementHomeScore();
            }
        }
    }
}
