using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class ExplosiveCane : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject explosion;
    public float radius = 1.0F;
    public float power = 1.0F;
    public AudioSource soundPlayExplode;
    public ParticleSystem Boom;
    public ParticleSystem Sparkels;

    //if the tag ball hit the object, it will explode

    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("ball"))
        {
            //make the explosion with the radius and power of the explosion
            Vector3 explosionPosition = transform.position;
            Collider[] colliders = Physics.OverlapSphere(explosionPosition, radius);
            foreach (Collider hit in colliders)
            {
                
                Rigidbody rb = hit.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    //add force to the object
                    Vector3 direction = (hit.transform.position - transform.position) * power;
                    rb.AddForce(direction, ForceMode.VelocityChange);
                }
            }

            //play the sound
            soundPlayExplode.Play();

            //make the cane disappear
            gameObject.SetActive(false);

            //make the explosion effect appear Boom and Sparkels
            Boom.Play();

            Sparkels.Play();
            

            //wait 2 seconds
            WaitForSeconds wait = new WaitForSeconds(2);

            //destroy the object

            //Destroy(explosion);


        }

    }

    void OnDrawGizmosSelected()
    {
        // Show range in unity devtool
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
