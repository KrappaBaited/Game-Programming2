using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
[CreateAssetMenu(fileName = "Legends", menuName ="ScriptableObjects/Legends")]
public class Legend : ScriptableObject
{
    // Common attributes for all Pokémon
    public string name;
    public int hp;
    public LegendType type;
    public Gender gender;
    public Sprite image;

}
