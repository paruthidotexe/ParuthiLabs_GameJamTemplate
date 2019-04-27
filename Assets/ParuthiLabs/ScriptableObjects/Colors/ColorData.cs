using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScrObj/ColorData")]
public class ColorData : ScriptableObject
{
    int id = 0;
    string colorName = "BlueBlack";
    string hexVal = "0x000000";
    float red = 0;
    float green = 0;
    float blue = 0;
    public Color colorSelectorUI;
}
