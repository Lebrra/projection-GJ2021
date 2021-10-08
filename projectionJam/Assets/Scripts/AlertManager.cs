using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AlertManager : MonoBehaviour
{
    // Handles all incoming alerts and displays them
    public static AlertManager instance;

    public float alertDuration = 5F;
    Coroutine currentAlert;

    [Header("UI Elements")]
    // maybe remove panel on nothing?
    public TextMeshProUGUI alertText;

    private void Awake()
    {
        if (instance) Destroy(instance);
        else instance = this;
    }

    public void DisplayNewAlert(string message)
    {
        // stop current alert
        // display new one

        if (currentAlert != null) StopCoroutine(currentAlert);
        currentAlert = StartCoroutine(DisplayAlert(message));
    }

    IEnumerator DisplayAlert(string message)
    {
        alertText.text = message;
        yield return new WaitForSeconds(alertDuration);

        alertText.text = "";
        currentAlert = null;
    }
}
