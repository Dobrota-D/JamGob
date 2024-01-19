using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    //Cane points given to the player 100 points
    [SerializeField]
    private int _points = 100;

    public ParticleSystem dust;

    //it a cane touches the trigger, it will add points to the score in the game manager
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("cane"))
        {
            GameManager.Instance.IncreaseScore(_points);
        }
    }

   
}
