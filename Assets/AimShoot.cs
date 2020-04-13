using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimShoot : MonoBehaviour
{
    public Camera cam;
    public float range = 100f;
    public ParticleSystem leftGun;
    public ParticleSystem rightGun;
   
    public GameObject gameManager;
    AudioSource laserSound;
    // Start is called before the first frame update
    void Start()
    {
        laserSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            Shoot();    
        }
    }
    void Shoot()
    {
        
        RaycastHit hit;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range) && Time.timeScale==1)
        {
            leftGun.Play();
            rightGun.Play();
            laserSound.Play();
           // Debug.Log(hit.transform.name);
            TargetObj target = hit.transform.GetComponent<TargetObj>();
            if(target!=null)
            {
                target.Hit();
            }

            gameManager.GetComponent<Gamemanager>().incrementScore();
               // target.Hit();
        }
        
    }
}
