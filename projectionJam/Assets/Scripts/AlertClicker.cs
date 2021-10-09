using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AlertClicker : MonoBehaviour, IPointerClickHandler
{
    // send message to AlertManager on click

    public string message;

    public virtual void OnPointerClick(PointerEventData eventData)
    {
        AlertManager.instance?.DisplayNewAlert(message);
    }

    /// <summary>
    /// Called via broadcast in RoomChanger. Tells object to reset from room change
    /// </summary>
    public virtual void ResetInteraction()
    {
        // on default no reset 
    }
}
