using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
    public Transform player;
    public Transform playerCamera;

    public Transform MapMemory1;

    public Transform MapMemory2;

    bool goToMemory1;
    bool goToMemory2;

    void Awake()
    {
        transform.position = MapMemory1.position;
    }

    void Update()
    {
        MoveCam();
        MoveConditions();
    }
    void LateUpdate()
    {
        Vector3 newPosition = player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;

        transform.rotation = Quaternion.Euler(90f, playerCamera.eulerAngles.y, 0f);
    }

    void MoveCam()
    {
        if (goToMemory1)
        {
            transform.position = Vector3.Lerp(transform.position, MapMemory1.position, Time.deltaTime);
        }
        else if (goToMemory2)
        {
            transform.position = Vector3.Lerp(transform.position, MapMemory2.position, Time.deltaTime);
        }
    }

    void MoveConditions()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            goToMemory1 = true;
            goToMemory2 = false;
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            goToMemory2 = true;
            goToMemory1 = false;
        }
    }
}
