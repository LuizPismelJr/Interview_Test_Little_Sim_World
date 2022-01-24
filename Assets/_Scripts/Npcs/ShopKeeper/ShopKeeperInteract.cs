using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Random = UnityEngine.Random;

public class ShopKeeperInteract : MonoBehaviour, IInteractable
{

    [Header("StorePanel")]
    [SerializeField] GameObject storePanel;

    [Header("UiInteraction")]
    [SerializeField]GameObject uiTalkTextGroup;

    [Header("TalkingBoxUiManager")]
    [SerializeField] TalkingBoxUiManager textToChange;

    [Header("WhatToSay")]
    [SerializeField] string[] saying;

    string currentTextToSend;

    public void Interact() 
    {
        SetStateOfOptionUI(true);
        TalkingToPlayer();
    }

    public void ExitInteration() 
    {
        SetStateOfOptionUI(false);
    }

    void SetStateOfOptionUI(bool state) 
    {
        uiTalkTextGroup.SetActive(state);
    }

    void TalkingToPlayer() 
    {
        int textToSendId = Random.Range(0, saying.Length);

        currentTextToSend = saying[textToSendId];
        
        textToChange.ChangeCurrentTextShow(currentTextToSend);
    }

    void ShowTheStoreGoods() 
    {
        storePanel.SetActive(true);
    }

}
