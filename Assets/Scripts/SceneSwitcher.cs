using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    [SerializeField] private string selectableTag = "SceneSwitcher";
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private Material disabledMaterial;
    [SerializeField] private string disabledPref;
    [SerializeField] private int sceneIndex;

    private Transform _selection;
    public Transform player;

    void Update()
    {
        if(!string.IsNullOrEmpty(disabledPref) && PlayerPrefs.GetString(disabledPref) != "SUCCESS"){
            this.GetComponent<Renderer>().material = disabledMaterial;
        } else {
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
                        if(sceneIndex == 1 || sceneIndex == 6) {
                            saveCustomPlayerPosition();
                            SceneManager.LoadScene(sceneIndex);
                        } else {
                            savePlayerPosition();
                            SceneManager.LoadScene(sceneIndex);
                        }
                    }
                }
            }
        }
    }
    
    public void savePlayerPosition() {
        PlayerPrefs.SetFloat("PosX", player.position.x);
        PlayerPrefs.SetFloat("PosY", player.position.y);
        PlayerPrefs.SetFloat("PosZ", player.position.z);
    }

    public void saveCustomPlayerPosition() {
        Debug.Log(selectableTag);
        if (selectableTag == "RoofGate") {
            PlayerPrefs.SetFloat("PosX", -4);
            PlayerPrefs.SetFloat("PosY", 11);
            PlayerPrefs.SetFloat("PosZ", -16);
        } else if (selectableTag == "LabToTownGate") {
            PlayerPrefs.SetFloat("PosX", -4);
            PlayerPrefs.SetFloat("PosY", 6.8f);
            PlayerPrefs.SetFloat("PosZ", -20);
        } else if (selectableTag == "HallwayToTownGate") {
            PlayerPrefs.SetFloat("PosX", 5.7f);
            PlayerPrefs.SetFloat("PosY", 4.5f);
            PlayerPrefs.SetFloat("PosZ", -28);
        } else if (selectableTag == "ApartmentToHallwayGate") {
            PlayerPrefs.SetFloat("PosX", 3.9f);
            PlayerPrefs.SetFloat("PosY", 5.5f);
            PlayerPrefs.SetFloat("PosZ", -8.5f);
        }
    }
}
