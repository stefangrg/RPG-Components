using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject handsRoot;
    public Entity entityFacing;

    private PlayerInput playerInput;
    private PlayerRaycast playerRaycast;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        playerRaycast = GetComponent<PlayerRaycast>();
    }

    private void OnEnable()
    {
        playerInput.onPickItem += OnPickItem;
        playerInput.onDropItem += OnDropItem;

        playerRaycast.OnEntityHit += OnHitEntity;
        playerRaycast.OnHitNothing += OnHitNothing;
    }

    private void OnDisable()
    {
        playerInput.onPickItem -= OnPickItem;
        playerInput.onDropItem -= OnDropItem;

        playerRaycast.OnEntityHit -= OnHitEntity;
        playerRaycast.OnHitNothing -= OnHitNothing;
    }

    private void OnHitNothing()
    {
        entityFacing = null;
    }

    private void OnHitEntity(Entity entity)
    {
        entityFacing = entity;
    }

    private void OnDropItem()
    {
        Debug.Log("Item dropped!");
    }

    private void OnPickItem()
    {
        Debug.Log("Picked item!");
    }

    public static Player FindObjectLocalPlayer()
    {
        Player[] playerObjects = FindObjectsOfType<Player>();
        Player localPlayer = null;

        // TO BE IMPLEMENTED

        return localPlayer;
    }
}
