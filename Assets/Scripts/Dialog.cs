using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialog
{
    public string name;

    [TextArea(3, 10)]
    public string[] messages;

    [TextArea(3, 10)]
    public string[] successMessages;

    [TextArea(3, 10)]
    public string[] failedMessages;
}
