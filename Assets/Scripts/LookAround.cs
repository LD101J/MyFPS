using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    //reference to teros, float for look speed,
    // on update check if the mouse is being disturbed(print to the console)
    // need variable to somewhere to store the coordinates
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private float lookSpeed;
    [SerializeField] private float horizontalMovement;
    [SerializeField] private float verticalMovement;
    //clamping
    [SerializeField] private float mouseYInput;
    [SerializeField] private int minValue;
    [SerializeField] private int maxValue;

   
    private void Update()
    {
        horizontalMovement = (Input.GetAxis("Mouse X") * lookSpeed);
        mouseYInput -= (Input.GetAxis("Mouse Y") * lookSpeed);
        mouseYInput = Mathf.Clamp(mouseYInput, minValue, maxValue);
        
        transform.Rotate(0, horizontalMovement, 0);
        mainCamera.transform.rotation = Quaternion.Euler(mouseYInput, mainCamera.transform.rotation.eulerAngles.y, 0f); 

    }
}
