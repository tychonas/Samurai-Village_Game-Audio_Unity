using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndQuestTrigger : MonoBehaviour
{

    public bool playerInEndTrigger;
    // Start is called before the first frame update
    void Start()
    {
        playerInEndTrigger = false;
    }

    void Update()
    {
        //Debug status of trigger
        //Debug.Log("EndTrigger Status ="+playerInEndTrigger);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "Player"){
            playerInEndTrigger = true;
        } 
    }

    void OnTriggerExit(Collider player) {
        if(player.gameObject.tag == "Player"){
            playerInEndTrigger = false;
        }
    }
 
}
