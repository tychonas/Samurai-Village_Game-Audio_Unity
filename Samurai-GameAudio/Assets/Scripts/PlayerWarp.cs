using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWarp : MonoBehaviour

// This script warps the player to locations for testing purposes as is not designed to be used in a final game. 

{
    // Start is called before the first frame update
    public Transform warpMarker1;
    public Transform warpMarker2;
    public Transform warpMarker3;
    public Transform warpMarker4;
    public Transform warpMarker5;
    public Transform warpMarker6;

    public Transform playerStartLocation;


    public Transform player;

    void Awake()
    {
        player.position = playerStartLocation.position;
        player.rotation = playerStartLocation.rotation;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            player.position = warpMarker1.position;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            player.position = warpMarker2.position;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            player.position = warpMarker3.position;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            player.position = warpMarker4.position;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            player.position = warpMarker5.position;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            player.position = warpMarker6.position;
        }
    }
}
