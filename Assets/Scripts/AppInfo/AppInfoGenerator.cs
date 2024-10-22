﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppInfoGenerator : MonoBehaviour
{
    [SerializeField] AppInfo[] premadeAppInfo;
    [SerializeField] TextAsset titlesList, descriptionsList;
    [SerializeField] Sprite[] logos;
    [SerializeField] float premadeChance = 0.5f;

    string[] titles;
    string[] descriptions;


    private void Awake()
    {
        if(titlesList != null)
        {
            titles = titlesList.text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
        }

        if(descriptionsList != null)
        {
            descriptions = descriptionsList.text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
        }
    }

    public AppInfo Generate()
    {
        if( UnityEngine.Random.value < premadeChance && premadeAppInfo.Length > 0)
        {
            return premadeAppInfo[UnityEngine.Random.Range(0, premadeAppInfo.Length)];
        }

        AppInfo appInfo = new AppInfo();

        appInfo.Title = "Default";
        string description = "Example: This is the %t app proposed, it is awesome, buy it now for 1000$";

        if(titles != null && titles.Length > 0)
        {
            appInfo.Title = titles[UnityEngine.Random.Range(0, titles.Length)];
        }

        if (logos != null && logos.Length > 0)
        {
            appInfo.Logo = logos[UnityEngine.Random.Range(0, logos.Length)];
        }

        if (descriptions != null && descriptions.Length > 0)
        {
            description = descriptions[UnityEngine.Random.Range(0, descriptions.Length)];
        }

        description = description.Replace("%t", appInfo.Title);

        appInfo.IsCoronaRelated = description.Contains("%c");

        description = description.Replace("%c", "");

        appInfo.Description = description;

        return appInfo;
    }

}

[System.Serializable]
public struct AppInfo
{
    public string Title;

    [TextArea]
    public string Description;

    public Sprite Logo;

    public bool IsCoronaRelated;

    public override string ToString()
    {
        return Title + " : " + Description;
    }
}
