using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordPickup : MonoBehaviour
{
    
    public bool playerCanPickupSword;
    
    void Awake()
    {
        playerCanPickupSword = false;
    }

    void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "Player"){
            playerCanPickupSword = true;
        }
    }

    void OnTriggerExit(Collider player)
    {
        if(player.gameObject.tag == "Player"){
            playerCanPickupSword = false;
        }
    }
}
