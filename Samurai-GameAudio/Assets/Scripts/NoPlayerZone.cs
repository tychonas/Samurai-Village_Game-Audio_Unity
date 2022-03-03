using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class NoPlayerZone : MonoBehaviour
{

    public bool playerInNoPlayerZone;

    public Image turnBack;

    Volume v;

    float t;
    // Start is called before the first frame update
    void Awake()
    {
        v = GetComponent<Volume>();


    }

    void Start()
    {
        v.weight = 0;
        playerInNoPlayerZone = false;
        var tempColor = turnBack.color;
        tempColor.a = 0;
    }

    // Update is called once per frame
    void Update()
    {
        t = 0.01f;
        var tempColor = turnBack.color;
        if (playerInNoPlayerZone == true && v.weight < 1)
        {
            tempColor.a += 0.02f;
            v.weight += t;

        }
        else if (playerInNoPlayerZone == false && v.weight > 0)
        {
            tempColor.a -= 0.02f;
            v.weight -= t;
        }

        turnBack.color = tempColor;

    }

    void OnTriggerEnter(Collider player)
    {
        playerInNoPlayerZone = true;
    }

    void OnTriggerExit(Collider player)
    {
        playerInNoPlayerZone = false;
    }




}
