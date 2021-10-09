using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeypadLogic : MonoBehaviour
{
    // All functions of a keypad - dynamic for different keypad types
    // Uses string types to allow number or word keycodes

    bool solved = false;
    public string answerKey;
    [SerializeField]
    string currentString = "";
    public int maxDigits = 3;

    [Header("UI Components")]
    public TextMeshProUGUI keycodeDisplay;

    [Header("Alternate Display")]
    [Tooltip("Replace text display visual with sprites\nDigits will still be used for logic comparison")]
    public bool useAlternateDisplay;
    public List<Sprite> alternateSprites;

    public void EnterDigit(int digit)
    {
        if (currentString.Length >= maxDigits) return;
        UpdateString(IntToString(digit));
    }

    public void ClearEntry()
    {
        currentString = "";
        if (!useAlternateDisplay && keycodeDisplay) keycodeDisplay.text = "";
        // todo: clear layout group of sprites if useAlternateDisplay
    }

    public void SubmitEntry()
    {
        if (answerKey.ToLower() == currentString.ToLower())
        {
            solved = true;
            Debug.Log("Keypad Solved!", gameObject);
            SolutionResult();
        }
        else
        {
            // todo: have some error visual/sound to tell the player they are wrong
            ClearEntry();
        }
    }

    protected virtual void SolutionResult()
    {
        BroadcastMessage("DisableInteraction");
        // what happens when its solved?
    }

    void UpdateString(string entry)
    {
        Debug.Log(entry);
        currentString = currentString + entry;
        if (!useAlternateDisplay && keycodeDisplay) keycodeDisplay.text = currentString;
        // todo: add sprite to layout group if useAlternateDisplay
    }

    /// <summary>
    /// If already a digit, return digit as string type. Else return number converted to letter (hexidecimal style)
    /// </summary>
    string IntToString(int value)
    {
        if (value < 10 && value > -1)
        {
            return value.ToString();
        }
        else
        {
            switch (value)
            {
                case 10: return "a";
                case 11: return "b";
                case 12: return "c";
                case 13: return "d";
                case 14: return "e";
                case 15: return "f";
                case 16: return "g";
                case 17: return "h";
                case 18: return "i";
                case 19: return "j";
                case 20: return "k";
                case 21: return "l";
                case 22: return "m";
                case 23: return "n";
                case 24: return "o";
                case 25: return "p";
                case 26: return "q";
                case 27: return "r";
                case 28: return "s";
                case 29: return "t";
                case 30: return "u";
                case 31: return "v";
                case 32: return "w";
                case 33: return "x";
                case 34: return "y";
                case 35: return "z";

                default: return "F";
            }
        }
    }
}
