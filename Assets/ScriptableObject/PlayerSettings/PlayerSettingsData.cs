using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "newPlayerSettings", menuName = "ScriptableObject/PlayerSettings")]
public class PlayerSettingsData : ScriptableObject
{
    public bool musicOn;
    public bool volumeOn;
    public float musicLoud;
    public float volumeLoud;
    public int moneyCount;
    public float xpProgress;
    public int lvl;
}