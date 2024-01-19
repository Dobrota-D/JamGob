using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class NormalCane : MonoBehaviour
{
    public AudioSource soundPlay;

    //if the cane hits the ground, play the sound
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            soundPlay.Play();
        }
    }
}
