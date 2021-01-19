using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsSystem : MonoBehaviour
{
    [SerializeField]
    private DefaultStats defaultStats;
    private Dictionary<StatType, Stat> stats = new Dictionary<StatType, Stat>();

    private void Awake()
    {
        //Create stats with static StatData info and default stats values

        Stat Health = new Stat(StatData.Health, defaultStats.HealthValue);
        AddStatInDictionary(Health);

        Stat AttackSpeed = new Stat(StatData.AttackSpeed, defaultStats.AttackSpeedValue);
        AddStatInDictionary(AttackSpeed);

        Stat MovementSpeed = new Stat(StatData.MovementSpeed, defaultStats.MovementSpeedValue);
        AddStatInDictionary(MovementSpeed);

    }

    private void AddStatInDictionary(Stat stat)
    {
        StatType statType = stat.GetStatData().GetStatType();

        if (stats.ContainsKey(statType)) return;
        stats.Add(statType, stat);
    }

    public float GetStatValue(StatType statType)
    {
        return stats[statType].Value;
    }

}
