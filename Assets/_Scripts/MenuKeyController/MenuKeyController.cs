using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuKeyController : MonoBehaviour
{
    [Header("TextWaitingAKeyBePressed")]
    [SerializeField] GameObject isWaitingAKey;

    [Header("ButtonFromTheMenu")]
    [SerializeField] GameObject menuButtons;

    private void Awake()
    {
        isWaitingAKey.SetActive(true); 
        menuButtons.SetActive(false);
    }

    void Update()
    {
        if (isWaitingAKey.activeInHierarchy) 
        {
            AnyKeyIsPressable();
        }
    }

    void AnyKeyIsPressable()
    {
        if (Input.anyKey) 
        {
            isWaitingAKey.SetActive(false);
            menuButtons.SetActive(true);
        }
    }

    void WaitingToFade(int timeToFade)
    {
        StartCoroutine(TimeToPass(timeToFade));
    }

    IEnumerator TimeToPass(int seconds) 
    {
       yield return new WaitForSeconds(seconds);
    }
}
