using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Object = System.Object;

public class WordDB : MonoBehaviour
{
    public string[] wordDB;
    public int count;
    public int counttwo;
    void Start()
    {
        foreach (TextAsset file in Resources.LoadAll<TextAsset>("Dict"))
        {
                string[] textValue = file.ToString().Split("\n");
                count += textValue.Length;
        }
        wordDB = new string[count];
        foreach (TextAsset file in Resources.LoadAll<TextAsset>("Dict"))
        {
                string[] textValue = file.ToString().Split("\n");
                if (textValue.Length > 0)
                {
                    for (int i = 0; i < textValue.Length; i++)
                    {
                        wordDB[counttwo] = textValue[i];
                        counttwo++;
                    }
                }
        }
    }
    
    public bool SearchWord(string word)
    {
        int index = Array.IndexOf(wordDB, word);
        if (index != -1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
