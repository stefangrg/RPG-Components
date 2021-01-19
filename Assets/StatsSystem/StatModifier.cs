using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Stat Modifier",menuName = "Stat Modifier")]
public class StatModifier : ScriptableObject
{
    public StatType statType;
    public float Value;
}
