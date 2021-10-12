using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1.0f;
    public CharacterController controller;

    // Update is called once per frame
    void Update()
    {

    float x = Input.GetAxis("Horizontal");
    float y = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0, y);
    movement = movement.normalized * speed * Time.deltaTime;

        //Vector3 newPosition = transform.position;
        //newposition = newPosition + movement;

        //transform.position = newPosition;
        controller.Move(movement);
 }

}
