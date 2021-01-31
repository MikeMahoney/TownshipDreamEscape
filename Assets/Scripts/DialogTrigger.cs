using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;
    [SerializeField] private string scenarioId;

    public void TriggerDialog () {
        string scenarioStatus = "";
        if (!PlayerPrefs.HasKey(scenarioId)) {
            PlayerPrefs.SetString(scenarioId, "STARTED");
        } else {
            scenarioStatus = PlayerPrefs.GetString(scenarioId);
        }
        Debug.Log(scenarioStatus);
        FindObjectOfType<DialogManager>().StartDialog(dialog, scenarioStatus);
    }
}
