using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimShoot : MonoBehaviour
{
    public Camera cam;
    public float range = 100f;
    public ParticleSystem leftGun;
    public ParticleSystem rightGun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("space"))
        {
            Shoot();    
        }
    }
    void Shoot()
    {
        leftGun.Play();
        rightGun.Play();
        RaycastHit hit;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            TargetObj target = hit.transform.GetComponent<TargetObj>();
            if(target!=null)
            {
                target.Hit();
            }
               // target.Hit();
        }
        
    }
}
