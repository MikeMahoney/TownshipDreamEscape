﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private GameObject cushionUIItem;
    [SerializeField] private GameObject tapeUIItem;
    private Color objectiveColor = new Color(134,147,255);
    private Color defaultColor = new Color(255,83,83);

    void Update()
    {
        if(PlayerPrefs.GetInt("CushionItem") == 1){
            cushionUIItem.SetActive(true);
        }
        if(PlayerPrefs.GetInt("TapeItem") == 1){
            tapeUIItem.SetActive(true);
        }
    }
}
