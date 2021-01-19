using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat
{
    private StatData statData;
    private float value = 0f;

    public float Value
    {
        get { return value; }
    }

    public Stat(StatData statData,float Value)
    {
        this.statData = statData;
        value = Value;
    }

    public StatData GetStatData()
    {
        return statData;
    }

    

    
}
