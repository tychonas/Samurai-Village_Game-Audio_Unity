using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketSellerTrigger : MonoBehaviour
{

    public bool playerIsInMarketSellerTrigger;
    // Start is called before the first frame update
    void Start()
    {
        playerIsInMarketSellerTrigger = false;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            playerIsInMarketSellerTrigger = true;
        }
    }

    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            playerIsInMarketSellerTrigger = false;
        }
    }
}
