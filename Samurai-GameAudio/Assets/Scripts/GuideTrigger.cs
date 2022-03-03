using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideTrigger : MonoBehaviour
{
    public SpriteRenderer guideImage;
    bool guideOn;

    public float guidefadetime;
    // Start is called before the first frame update
    void Start()
    {
        guideOn = false;
        var tempcolor = guideImage.color;
        tempcolor.a = 0;
        guidefadetime = 0.08f;

    }

    // Update is called once per frame
    void Update()
    {
        GuideFade();
      
        
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            guideOn = true;
        }
    }

    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            guideOn = false;
        }
    }

    void GuideFade()
    {
        var tempcolor = guideImage.color;

        if (guideOn == true && tempcolor.a < 1)
        {
          
            tempcolor.a += guidefadetime;

        }
        else if (guideOn == false && tempcolor.a > 0)
        {
            tempcolor.a -= guidefadetime;
      
        }
        guideImage.color = tempcolor;
    }
}
