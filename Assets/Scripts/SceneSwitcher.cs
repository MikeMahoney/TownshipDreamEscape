﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    [SerializeField] private string selectableTag = "SceneSwitcher";
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private int sceneIndex;
    [SerializeField] private float[] playerPosition = new float[3];

    private Transform _selection;
    public Transform player;

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
                    if(sceneIndex == 1) {
                        Debug.Log(playerPosition[0]);
                        if (playerPosition[0] != 0) {
                            saveCustomPlayerPosition();
                        }
                        SceneManager.LoadScene(sceneIndex);
                    } else {
                        Debug.Log(sceneIndex);
                        if (playerPosition[0] != 0) {
                            saveCustomPlayerPosition();
                        } else {
                            savePlayerPosition();
                        }
                        SceneManager.LoadScene(sceneIndex);
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
        PlayerPrefs.SetFloat("PosX", playerPosition[0]);
        PlayerPrefs.SetFloat("PosY", playerPosition[1]);
        PlayerPrefs.SetFloat("PosZ", playerPosition[2]);
    }
}
