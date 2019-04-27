using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


[CreateAssetMenu(menuName = "ScrObj/ColorDataList")]
public class ColorDataList : ScriptableObject
{
    List<ColorData> colorDataList = new List<ColorData>();
    public List<Color> colorList = new List<Color>();

    Color[] basicColorList;
    int basicColors = 8;

    Color[] greyColorList;
    int totalGreyParts = 16;


    public void CreateBasicList()
    {
        basicColorList = new Color[]
        {
            new Color(0, 0, 0, 1),
            new Color(1, 1, 1, 1),
            new Color(1, 0, 0, 1),
            new Color(0, 1, 0, 1),
            new Color(0, 0, 1, 1),
            new Color(1, 1, 0, 1),
            new Color(0, 1, 1, 1),
            new Color(1, 0, 1, 1),
        };
    }


    public void CreateGreyList()
    {
        greyColorList = new Color[totalGreyParts];
        float colorDiff = (256.0f / (float)totalGreyParts) / 256.0f;
        float curColor = colorDiff;
        for (int i = 0; i < greyColorList.Length; i++)
        {
            greyColorList[i] = new Color(curColor, curColor, curColor);
            curColor += colorDiff;
        }
    }


    private void OnEnable()
    {
        CreateBasicList();
        CreateGreyList();
        CreateFinalList();
    }


    public void CreateFinalList()
    {
        colorList.Clear();
        colorList.AddRange(basicColorList);
        colorList.AddRange(greyColorList);
    }

}
