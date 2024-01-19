using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCane : MonoBehaviour
{
    //This cane will reset the multiplier to 1
    public int multiplier = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            //reset the multiplier to 1
            GameManager.Instance.Multiplier = multiplier;

            //make the cane disappear
            gameObject.SetActive(false);
        }
    }
}
