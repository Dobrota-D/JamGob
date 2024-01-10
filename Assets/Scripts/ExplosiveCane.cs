using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveCane : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject explosion;
    public float radius = 5.0F;
    public float power = 10.0F;

    //if the tag ball hit the object, it will explode

    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("ball"))
        {
            Debug.Log("Explosion");
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

            //destroy the object

            Destroy(explosion);


        }
    }
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
