using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InteractiveClicker : AlertClicker
{
    // Clicking on this object causes a sprite change and is no longer interactable. Changing scenes resets the object

    [Header("Interactive Properties")]
    Image myImage;
    Sprite initialSprite;
    public Sprite interactedSprite;
    [SerializeField]
    bool interacted = false;

    void Start()
    {
        myImage = GetComponent<Image>();
        initialSprite = myImage.sprite;
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        if (!interacted)
        {
            base.OnPointerClick(eventData);

            interacted = true;
            myImage.raycastTarget = false;
            myImage.sprite = interactedSprite;
        }
    }

    /// <summary>
    /// Called via broadcast in RoomChanger. Tells object to reset from room change
    /// </summary>
    public override void ResetInteraction()
    {
        Debug.Log("Reseting " + gameObject.name, gameObject);
        interacted = false;
        myImage.raycastTarget = true;
        myImage.sprite = initialSprite;
    }
}
