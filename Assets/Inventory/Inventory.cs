using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Entity> items = new List<Entity>();
    private Player player;

    private void Awake() 
    {
        player = GetComponent<Player>();
    }
}
