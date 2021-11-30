using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    [SerializeField] private GameObject shopItemError;
    [SerializeField] private int itemCost;

    void Update() {
        if (PlayerPrefs.GetInt(gameObject.name) == 1 && gameObject.activeSelf) {
            gameObject.SetActive(false);
        }
    }
    public void OnClickShopItem()
    {
        int currentMoney = PlayerPrefs.GetInt("Money");
        if (currentMoney >= itemCost) {
            PlayerPrefs.SetInt(gameObject.name, 1);
            PlayerPrefs.SetInt("Money", currentMoney - itemCost);
        } else {
            StartCoroutine(showError());
        }
    }

    IEnumerator showError (){
        shopItemError.SetActive(true);
        yield return new WaitForSeconds (2);
        shopItemError.SetActive(false);
    }
}
