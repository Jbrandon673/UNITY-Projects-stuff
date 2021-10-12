using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermov : MonoBehaviour
{
    public Rigidbody player;
    public float speed;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            player.AddForce(0, 0, speed * Time.deltaTime);
        }

    }
        
   }

     
        



                

               
            
  
        
        


            
















