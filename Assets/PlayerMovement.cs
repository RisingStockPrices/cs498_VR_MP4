using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    float speed = 5f;
    bool isMoving = false;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        if (x!=0 || z!=0) //movement
        {

            Vector3 translate = transform.right * x + transform.forward * z;
            controller.Move(translate * speed);
            isMoving = true;
           
        }
        else
        {
            isMoving = false;
        }

        anim.SetBool("IsMoving", isMoving);
    }
     void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag=="StartGame")
        {//jump to game scene
            SceneManager.LoadScene(sceneName: "CS498HW4");
        }
        else if(collision.gameObject.tag=="EndGame")
        {
            print("attempting to quit");
            Application.Quit();
        }
    }
}
