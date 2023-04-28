using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue file", menuName = "Dialogue Files Archive")]
public class Dialogue : ScriptableObject
{

    [TextArea(3,15)]
    public string[] dialogue;
}
