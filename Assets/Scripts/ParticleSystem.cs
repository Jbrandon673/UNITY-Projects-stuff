using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystem : MonoBehaviour
{
    public GameObject triggerParticle;
    public GameObject collisionParticle;

    //Get executed when something enters this trigger, or when this object enters a trigger
    private void OnTriggerEnter(Collider other)
    {
        if (triggerParticle != null)
        {
            //The triggerParticle will be spawned at the location of this object
            //with the same rotation as this object
            Instantiate(triggerParticle, this.transform.position, this.transform.rotation);
        }
        
    }
    void Start()
    {
        
    }

    // Gets executed when something collides with this object
    private void OnCollisonEnter(Collision collision)
    {
        if (collisionParticle != null)
        {

            Instantiate(collisionParticle, collision.contacts[0].point, this.transform.rotation);
        }
        
    }
}
