using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetObj : MonoBehaviour
{
    AudioSource explosionSFX;
    
    private void Start()
    {
        explosionSFX = GetComponent<AudioSource>();
    }
    public void tempKill()
    {
        gameObject.SetActive(false);
        explosionSFX.Play();
        Invoke("Resurrect", 5);
    }
    public void Hit()
    {
        Invoke("tempKill", 0.5f);
        
    }

    public void Resurrect()
    {
        gameObject.SetActive(true);
    }
  
}
