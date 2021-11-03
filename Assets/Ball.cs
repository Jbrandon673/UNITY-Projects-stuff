using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour {
    private Vector3 startPosition;
    Rigidbody myRb;
    bool setSpeed;
    [SerializeField] float speedUp;
    float xspeed;
    float yspeed;
    
    private Vector3 direction;

    public float speed;

    [SerializeField]
    private int playerOneScore;
    [SerializeField]
    private int playerTwoScore;

    public Vector3 spawnPoint;

    public GameObject goalEffect;

    public Text playerOneText;
    public Text playerTwoText;
    private static Vector2 Velocity;

    // Start is called before the first frame update
    void Start() {
        startPosition = transform.position;
        Launch();
        myRb = GetComponent<Rigidbody>();
        playerOneScore = 0;
        playerTwoScore = 0;
        GetComponent<Rigidbody>().AddForce(Vector3.right * speed,ForceMode.Impulse);

    }

    public void reset()
    {
        myRb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }
    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        myRb.velocity = new Vector2(speed * x, speed * y);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "PLAYER1")
        {
            GameController.intstance.scoreOne ++;
            GameController.intstance.textOne.text = GameController.intstance.scoreOne.ToString();
            GameController.intstance.inPlay = false;
            myRb.velocity = Vector2.zero;
            transform.position = Vector2.zero;
        }
        else if(other.tag != "PLAYER2")
        {
            GameController.intstance.scoreTwo ++;
            GameController.intstance.textTwo.text = GameController.intstance.scoreTwo.ToString();
            GameController.intstance.inPlay = false;
            myRb.velocity = Vector2.zero;
            transform.position = Vector2.zero;
        }
    }

    // Update is called once per frame
    void Update() {
        this.transform.position += direction * speed;
        playerOneText.text = playerOneScore.ToString();
        playerTwoText.text = playerTwoScore.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 normal = collision.contacts[0].normal;
        direction = Vector3.Reflect(direction, normal);

        if (collision.gameObject.name == "WestWall")
        {
            playerTwoScore++;
            Instantiate(goalEffect, this.transform.position, Quaternion.identity);
            transform.position = spawnPoint;
        }

        if (collision.gameObject.name == "EastWall")
        {
            playerOneScore++;
            Instantiate(goalEffect, this.transform.position, Quaternion.identity);
            transform.position = spawnPoint;
        }
    }
}   


    

