using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeekPickup : MonoBehaviour
{
    // Start is called before the first frame update
    public bool playerIsInLeekTrigger;

    void Start()
    {
        playerIsInLeekTrigger = false;
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            playerIsInLeekTrigger = true;
        }
    }

    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            playerIsInLeekTrigger = false;
        }
    }

}
