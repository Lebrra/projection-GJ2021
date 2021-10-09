using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightMover : MonoBehaviour
{
    // Moves UI mask object while keeping childed hidden object in place

    public GameObject myHiddenObject;
    Vector3 startingPosition;

    private void Start()
    {
        startingPosition = new Vector3(transform.position.x, transform.position.y);
    }

    public void MoveHorizontally(float value)
    {
        Vector3 myObjectPosition = new Vector3(myHiddenObject.transform.position.x, myHiddenObject.transform.position.y);
        transform.position = new Vector3(startingPosition.x + value, transform.position.y);
        myHiddenObject.transform.position = myObjectPosition;
    }

    public void MoveVertically(float value)
    {
        Vector3 myObjectPosition = new Vector3(myHiddenObject.transform.position.x, myHiddenObject.transform.position.y);
        transform.position = new Vector3(transform.position.x, startingPosition.y + value);
        myHiddenObject.transform.position = myObjectPosition;
    }
}
