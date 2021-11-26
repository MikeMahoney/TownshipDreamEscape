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
        if (Physics.Raycast(ray, out hit, 2)) {
            var selection = hit.transform;
            Debug.Log(hit.transform);
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

    public void saveInventoryItem(string itemName) {
        if(PlayerPrefs.GetInt(itemName) != 1) {
            PlayerPrefs.SetInt(itemName, 1);
            // Set TAKEN so it doesn't reappear
            PlayerPrefs.SetInt(itemName + "TAKEN", 2);
        }
    }
}
