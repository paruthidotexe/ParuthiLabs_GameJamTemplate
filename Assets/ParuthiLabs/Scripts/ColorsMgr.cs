using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class ColorsMgr : MonoBehaviour
{
    public int width = 16;
    public int height = 16;
    public int imgWidth = 512;
    public int imgHeight = 512;

    public ColorDataList colorDataList;

    void Start()
    {
        CreateImages();
    }


    void Update()
    {
    }


    void CreateImages()
    {
        Texture2D newTex = new Texture2D(imgWidth, imgHeight, TextureFormat.RGB24, false);
        var dirPath = Application.dataPath + "/../SaveImages/";
        int rowX = 0;
        int rowY = 0;
        for (int i = 0; i < colorDataList.colorList.Count; i++)
        {
            rowX = i * width;
            rowY = (i * width) / (imgWidth) * height;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    newTex.SetPixel(rowX + x, imgHeight - y, colorDataList.colorList[i]);
                }
            }
        }
        newTex.Apply();
        byte[] bytes = newTex.EncodeToPNG();
        if (!Directory.Exists(dirPath))
        {
            Directory.CreateDirectory(dirPath);
        }
        File.WriteAllBytes(dirPath + "Image_" + "i" + ".png", bytes);
    }


}
