using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public EntitySO EntityData;
    public bool Pickable
    {
        get { return EntityData.pickable; }
    }


    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
