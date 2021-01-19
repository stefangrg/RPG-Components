using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    public UnityAction onPickItem;
    public UnityAction onDropItem;

    void Update()
    {
        CheckInput();
    }

    private void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            onPickItem?.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            onDropItem?.Invoke();
        }
    }
}
