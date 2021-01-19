using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatType { Health, Movement, AttackSpeed }

public class StatData
{
    public readonly static StatData Health = new StatData("Viata", StatType.Health);
    public readonly static StatData AttackSpeed = new StatData("Viteza de atac", StatType.AttackSpeed);
    public readonly static StatData MovementSpeed = new StatData("Viteza de miscare", StatType.Movement);

    private string statName;
    private StatType statType;

    public StatData(string statName,StatType statType)
    {
        this.statName = statName;
        this.statType = statType;
    }

    public string GetName()
    {
        return statName;
    }

    public StatType GetStatType()
    {
        return statType;
    }
}
