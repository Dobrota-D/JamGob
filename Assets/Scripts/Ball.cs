using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

   
    //if the ball hits the cane, play the sound
    public AudioSource soundPlayCane;

    private void OnCollisionEnter(Collision collision)
    {
         if (collision.gameObject.CompareTag("cane"))
        {
              soundPlayCane.Play();
         }
    }

   

}
