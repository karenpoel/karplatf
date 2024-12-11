using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [Header("Target Teleport Location")]
    public Transform teleportDestination;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = teleportDestination.position;

            Debug.Log("Player teleported to: " + teleportDestination.position);
        }
    }
    
}


