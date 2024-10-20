using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using DG.Tweening;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private TMP_Text promptText;

    
    public void UpdateText(string promptMessage)
    {
        promptText.text = promptMessage;
    }
}
