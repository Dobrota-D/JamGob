using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiScoreCane : MonoBehaviour
{
    //This Cane will times the multiplier from the game manager by 2 each time the cane is hit by the ball
    public int multiplier = 2;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            Debug.Log("Multiplier Cane Hit");
            //add the multiplier to the game manager
            GameManager.Instance.Multiplier *= multiplier;

            //make the cane disappear
            gameObject.SetActive(false);
        }
    }
    

}
