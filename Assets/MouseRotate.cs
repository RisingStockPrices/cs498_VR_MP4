using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotate : MonoBehaviour
{
    public float mouseSens = 50f;
    public Transform playerT;

    float xRot = 0f;
    // Start is called before the first frame update
    void Start()
    {

        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;

        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -45f, 45f);

        if (xRot < 30f && xRot > -30f)
            playerT.Rotate(Vector3.left * mouseY);
        //mouseY = Mathf.Clamp(mouseY, -45f, 45f);
        //transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        //playerT.Rotate(Vector3.forward * xRot);
        playerT.Rotate(Vector3.up*mouseX);

    }
}
