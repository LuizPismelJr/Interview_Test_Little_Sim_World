using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopKeeperInteract : MonoBehaviour, IInteractable
{
    [Header("UiInteraction")]
    [SerializeField]GameObject UiTest;

    [Header("UiInteraction")]
    [SerializeField] TextMeshProUGUI textTest;

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
        textTest.text = "vai se fuder douzane";
    }

    void ShowTheStoreGoods() 
    {

    }

}
