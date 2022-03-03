using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheLeekQuest : MonoBehaviour
{
    [Header("Triggers")]
    public GameObject leekTrigger;
    public GameObject marketSellerTrigger;

    [Header("UI Elements")]
    public GameObject pressToTalkUI;
    public GameObject pressToPickUpUI;
    public GameObject pressToGiveUI;
    public GameObject leekUIImage;
    [Header("Items")]
    public GameObject leekToCollect;
    public GameObject leekToGive;
    public bool questStarted;
    bool doesPlayerHaveLeek;
    // Start is called before the first frame update
    void Start()
    {
        questStarted = false;
        pressToGiveUI.SetActive(false);
        pressToPickUpUI.SetActive(false);
        pressToTalkUI.SetActive(false);
        leekToGive.SetActive(false);
        leekUIImage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        LeekPickup();
        MarketSellerStart();
        MarketSellerEnd();
    }

    void MarketSellerStart()
    {
        if (marketSellerTrigger.GetComponent<MarketSellerTrigger>().playerIsInMarketSellerTrigger == true && questStarted == false)
        {
            pressToTalkUI.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                //Add your conversation here

                questStarted = true;
                pressToTalkUI.SetActive(false);
            }
        }
    }
    void LeekPickup()
    {
        if (questStarted == true && leekTrigger.GetComponent<LeekPickup>().playerIsInLeekTrigger == true)
        {
            if (doesPlayerHaveLeek == false)
            {
                pressToPickUpUI.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    pressToPickUpUI.SetActive(false);
                    Destroy(leekToCollect);
                    doesPlayerHaveLeek = true;
                    leekUIImage.SetActive(true);


                }
            }
        }
    }
    void MarketSellerEnd()
    {
        if (doesPlayerHaveLeek == true && marketSellerTrigger.GetComponent<MarketSellerTrigger>().playerIsInMarketSellerTrigger == true)
        {
            pressToGiveUI.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                doesPlayerHaveLeek = false;
                pressToGiveUI.SetActive(false);
                leekToGive.SetActive(true);
                leekUIImage.SetActive(false);
            }
        }
    }


}
