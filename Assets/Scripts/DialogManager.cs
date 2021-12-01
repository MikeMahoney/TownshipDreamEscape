using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    private Queue<string> messages;
    [SerializeField] private GameObject dialogPanel;

    public Text nameText;
    public Text dialogText;

    void Start()
    {
        messages = new Queue<string>();
    }

    public void StartDialog(Dialog dialog, string status) {
        nameText.text = dialog.name;
        dialogPanel.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        messages.Clear();

        string[] currentMessages = dialog.messages;
        if (status == "SUCCESS") {
            currentMessages = dialog.successMessages;
        } else if (status == "FAILED") {
            currentMessages = dialog.failedMessages;
        }

        foreach (string message in currentMessages) {
            messages.Enqueue(message);
        }

        DisplayNextMessage();
    }

    public void DisplayNextMessage() {
        if (messages.Count == 0) {
            EndDialog();
            return;
        }
        string message = messages.Dequeue();

        dialogText.text = message;
    }

    public void EndDialog() {
        dialogPanel.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
