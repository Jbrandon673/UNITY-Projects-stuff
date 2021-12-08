using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float turnspeed = 90f;
    private int score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Obstacle>() != null)
        {
            Destroy(gameObject);
            return;
        }
        // Check that object we collided with is player
        if (other.gameObject.name != "Player")
        {
            return;
        }

        // Add to the player's score
        

        // Destroy this coin object
        Destroy(gameObject);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(0, 0, turnspeed * Time.deltaTime);
    }
}
