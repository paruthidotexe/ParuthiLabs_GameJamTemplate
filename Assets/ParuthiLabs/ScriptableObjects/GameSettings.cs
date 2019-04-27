using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "ScrObj/Settings")]
public class GameSettings : ScriptableObject
{
    public string gameName = "ParuthiLabsTemplate";
    public string playerName = "Paruthi";
    public int gameMode = 0;
    public bool isGamePaused = false;
}

