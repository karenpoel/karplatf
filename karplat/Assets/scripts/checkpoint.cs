using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public Transform player;
    public int index;

    void Awake()
    {
        player = GameObject.Find("Character").transform;
        if(DataContainer.checkpointIndex == index)
        {
            player.position = transform.position;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
      if(other.gameObject.name == "Character")
        {
            if(index > DataContainer.checkpointIndex)
            {
                DataContainer.checkpointIndex = index;
            }
            
        }
    }
}
