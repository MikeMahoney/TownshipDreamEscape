using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickInventory : MonoBehaviour
{
    [SerializeField] private GameObject itemError;
    [SerializeField] private GameObject inventory;
    [SerializeField] private string itemName;

    public void OnClickDefaultItem() {
        if (PlayerPrefs.GetInt("ObjectiveMode") != 1 || PlayerPrefs.GetString("CurrentObjective") != itemName) {
            StartCoroutine(showError());
        } else if (PlayerPrefs.GetString("CurrentObjective") == itemName) {
            PlayerPrefs.SetString(itemName, "SET");
            gameObject.SetActive(false);

            inventory.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    IEnumerator showError (){
        itemError.SetActive(true);
        yield return new WaitForSeconds (2);
        itemError.SetActive(false);
    }
}
