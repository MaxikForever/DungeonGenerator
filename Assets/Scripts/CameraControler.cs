using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{

    private float mouseX;
    private float mouseY;
    [Header("Sensitivity")]

    public float sensitivityMouse = 200f;

    public Transform Player;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;    
    }

    // Update is called once per frame
    private void Update()
    {
        mouseX = Input.GetAxis("Mouse X")*sensitivityMouse * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y")*sensitivityMouse * Time.deltaTime;

        Player.Rotate(mouseX*new Vector3(0,1,0));

        transform.Rotate(-mouseY*new Vector3(1,0,0));

    }
}
