using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomChanger : MonoBehaviour
{
    // For transitioning to different roomsides

    public List<GameObject> roomSides;
    public int currentIndex = 0;

    void Start()
    {
        SetSide(0);
    }

    public void IncrementIndex()
    {
        currentIndex = (currentIndex + 1 ) % roomSides.Count;
        SetSide(currentIndex);
    }

    public void DecrementIndex()
    {
        if (currentIndex == 0) currentIndex = roomSides.Count - 1;
        else currentIndex--;
        SetSide(currentIndex);
    }

    void SetSide(int index)
    {
        foreach(var side in roomSides)
        {
            side.SetActive(false);
        }

        if (index > -1 && index < roomSides.Count)
            roomSides[index].SetActive(true);
        else
            Debug.LogError("Invalid room index: " + index);
    }
}
