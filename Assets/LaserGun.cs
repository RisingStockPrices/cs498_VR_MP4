using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGun : MonoBehaviour
{
    float xRot = 0f;
    float yRot = 0f;
    // Start is called before the first frame update
    void Start()
    {
        print("heyya");
       Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        //mouseX = Mathf.Clamp(mouseX, -45f, 45f);
        //mouseY = Mathf.Clamp(mouseY, -45f, 45f);

        xRot -= mouseY;
        yRot += mouseX;
        xRot = Mathf.Clamp(xRot, -35f, 5f);
        yRot = Mathf.Clamp(yRot, -45f, 45f);
        transform.localRotation = Quaternion.Euler(xRot, yRot, 0f);
        //transform.Rotate(Vector3.up * mouseX);
        //transform.Rotate(Vector3.left*mouseY);// = Quaternion.Euler(0, mouseX, 0);
    }
}
