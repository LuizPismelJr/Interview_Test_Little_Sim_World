using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Random = UnityEngine.Random;

public class ShopKeeperInteract : MonoBehaviour, IInteractable
{
    [Header("UiInteraction")]
    [SerializeField]GameObject UiTest;

    [Header("BoxUiManager")]
    [SerializeField] BoxUiManager textToChange;

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
        UiTest.SetActive(state);
    }

    void TalkingToPlayer() 
    {
        int textToSendId = Random.Range(0, saying.Length);
        Debug.Log(textToSendId);

        currentTextToSend = saying[textToSendId];
        
        textToChange.ChangeCurrentTextShow(currentTextToSend);
    }

    void ShowTheStoreGoods() 
    {

    }

}
