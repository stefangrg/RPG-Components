using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class UIManager : MonoBehaviour
{
    private static UIManager m_instance;
    public static UIManager Instance
    {
        get
        {
            if (m_instance == null)
                m_instance = FindObjectOfType<UIManager>();
            return m_instance;
        }
    }

    private MessagePopUp messagePopUp;
    private PlayerRaycast playerRaycast;

    private void Awake()
    {
        if (Instance != this) Destroy(gameObject);
        playerRaycast = FindObjectOfType<PlayerRaycast>();
        messagePopUp = FindObjectOfType<MessagePopUp>();
    }

    private void OnEnable()
    {
        playerRaycast.OnEntityHit += OnPlayerHitEntity;
    }

    private void OnDisable()
    {
        playerRaycast.OnEntityHit -= OnPlayerHitEntity;
    }

    private void OnPlayerHitEntity(Entity entity)
    {
        if (entity.Pickable)
        {
            ShowPopUpMessage("Press E to pick object!");
        }
    }

    public void ShowPopUpMessage(string message)
    {
        messagePopUp.ShowMessage(message);
    }

    
}
