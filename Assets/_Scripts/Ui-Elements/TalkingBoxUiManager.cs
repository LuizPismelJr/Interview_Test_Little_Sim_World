using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TalkingBoxUiManager : MonoBehaviour
{
    [Header("UiInteraction")]
    [SerializeField] TextMeshProUGUI textBox;

    public void ChangeCurrentTextShow(string textRecived) 
    {

        textBox.text = textRecived;
    }
}
