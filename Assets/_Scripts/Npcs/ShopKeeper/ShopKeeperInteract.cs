using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeeperInteract : MonoBehaviour, IInteractable
{
    [Header("UiInteraction")]
    [SerializeField]GameObject UiTeste;

    public void Interact() 
    {
        SetStateOfOptionUI(true);
    }

    public void ExitInteration() 
    {
        SetStateOfOptionUI(false);
    }

    void SetStateOfOptionUI(bool state) 
    {
        UiTeste.SetActive(state);
    }

    void TalkingToPlayer() 
    {

    }

    void ShowTheStoreGoods() 
    {

    }

}
