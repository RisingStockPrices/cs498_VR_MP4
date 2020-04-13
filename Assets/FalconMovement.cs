using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalconMovement : MonoBehaviour
{
    CharacterController controller;
    public GameObject gManager;
    public float speed = 200f;
    public float minSpeed = 100f;
    public float maxSpeed = 300f;
    public float boostSpeed = 500f;
    float speedSensitivity = 2f;
    float turnSensitivity = .5f;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();    
    }

    // Update is called once per frame
    void Update()
    {
        float accel = Input.GetAxis("Vertical");
        float yaw = Input.GetAxis("Fire2");
        float pitch = Input.GetAxis("Fire1"); // x axis, controls: TG
        float roll = Input.GetAxis("Horizontal"); // z axis, controls : HF

        //Vector3 rot = transform.forward * roll + transform.up * yaw + transform.right * pitch;
        Vector3 rot = Vector3.back * roll + Vector3.up * yaw + Vector3.left * pitch;
        transform.Rotate(rot * turnSensitivity);

        speed += accel * speedSensitivity;
        speed = Mathf.Clamp(speed, minSpeed, maxSpeed);

        float befBoostSpeed = speed;

        if (Input.GetKey(KeyCode.LeftShift))
            speed = boostSpeed;

        Vector3 translate = transform.forward * speed * Time.deltaTime;
        controller.Move(translate);

        speed = befBoostSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        gManager.GetComponent<Gamemanager>().gameOver();
        print("collision!");
    }
}
