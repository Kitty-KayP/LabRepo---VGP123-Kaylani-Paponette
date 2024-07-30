using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("OneUp"))
        {
            Destroy(other.gameObject);
            // Perform actions when the player collects the object
            // Add score, play a sound, or activate a power-up
            //Collect();
        }
    }

}
