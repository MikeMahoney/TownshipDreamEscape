using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private GameObject cushionUIItem;
    [SerializeField] private GameObject tapeUIItem;
    [SerializeField] private GameObject seedsShopItem;
    [SerializeField] private GameObject mojitoShopItem;
    [SerializeField] private GameObject margaritaShopItem;
    [SerializeField] private GameObject oldFashionedShopItem;
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
        if(PlayerPrefs.GetInt("SeedsShopItem") == 1){
            seedsShopItem.SetActive(true);
        }

        if(PlayerPrefs.GetInt("MojitoShopItem") == 1){
            mojitoShopItem.SetActive(true);
        }
        if(PlayerPrefs.GetInt("MargaritaShopItem") == 1){
            margaritaShopItem.SetActive(true);
        }
        if(PlayerPrefs.GetInt("OldFashionedShopItem") == 1){
            oldFashionedShopItem.SetActive(true);
        }
    }
}
