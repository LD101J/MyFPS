using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    //variable to reference what we want to move
    //get his initial position at start
    //in update we check what button player presses and move that direction
    [SerializeField] private GameObject teros;
    [SerializeField] private Transform terosPos;
    [SerializeField] private bool showCursor;
    [SerializeField] private float sensitivity;

    private void Start()
    {
        if(showCursor == false)
        {
            Cursor.visible = false;
        }
    }
}
