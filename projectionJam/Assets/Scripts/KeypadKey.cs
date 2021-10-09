using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadKey : MonoBehaviour
{
    // On keypad solved, set interactible on keys to false

    public void DisableInteraction()
    {
        GetComponent<UnityEngine.UI.Button>().interactable = false;
    }
}
