using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AlertClicker : MonoBehaviour, IPointerClickHandler
{
    // send message to AlertManager on click

    public string message;

    public void OnPointerClick(PointerEventData eventData)
    {
        AlertManager.instance?.DisplayNewAlert(message);
    }
}
