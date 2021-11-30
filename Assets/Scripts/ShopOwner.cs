using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopOwner : MonoBehaviour
{
    [SerializeField] private GameObject shopMenu;
    public void OnClickShopOwner()
    {
        shopMenu.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
