using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MessagePopUp : MonoBehaviour
{
    public Image MessageBox;
    public TextMeshProUGUI messageText;

    private bool isActive = false;

    public void ShowMessage(string message)
    {
        messageText.text = message;
        isActive = true;
    }

    private void Update()
    {
        if (!isActive && MessageBox.enabled)
        {
            MessageBox.enabled = false;
            messageText.enabled = false;
            if (GameManager.Instance.debugMode) Debug.Log(gameObject.name + " | Disable GUI Message Panel");
        }
        else if (isActive && !MessageBox.enabled)
        {
            MessageBox.enabled = true;
            messageText.enabled = true;
            if (GameManager.Instance.debugMode) Debug.Log(gameObject.name + " | Enable GUI Message Panel");
        }

        isActive = false;
    }

    public void HideMessage()
    {
        MessageBox.enabled = false;
    }
}
