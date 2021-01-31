using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";
    [SerializeField] private string connectedTo = "";
    [SerializeField] private bool inventoryItem;
    [SerializeField] public GameObject inventory;
    [SerializeField] private bool objectiveItem;
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;
    private Transform _selection;
    public Transform player;

    [SerializeField] private UnityEvent callback;

    void Update()
    {
        if (_selection != null) {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1)) {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag)) {
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null) {
                    selectionRenderer.material = highlightMaterial;
                }
                _selection = selection;
                if (Input.GetMouseButtonDown(0)) {
                    if (selection.name != "ObjectiveMarker") {
                        saveInventoryItem(selectableTag);
                    } else if (selection.name == "ObjectiveMarker" && connectedTo != "") {
                        PlayerPrefs.SetInt("ObjectiveMode", 1);
                        PlayerPrefs.SetString("CurrentObjective", connectedTo);
                        Cursor.visible = true;
                        Cursor.lockState = CursorLockMode.None;
                        inventory.SetActive(true);
                    }
                    callback.Invoke();
                }
            }
        }
    }
    
    public void savePlayerPosition() {
        PlayerPrefs.SetFloat("PosX", player.position.x);
        PlayerPrefs.SetFloat("PosY", player.position.y);
        PlayerPrefs.SetFloat("PosZ", player.position.z);
    }

    public void saveInventoryItem(string itemName) {
        if(PlayerPrefs.GetInt(itemName) != 1) {
            PlayerPrefs.SetInt(itemName, 1);
        }
    }
}
