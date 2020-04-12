using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPause : MonoBehaviour
{
    public GameObject pausePanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //game currently paused
        if(pausePanel.activeInHierarchy)
        {
            //resume
            if(Input.GetKeyDown(KeyCode.R))
            {
                Time.timeScale = 1;
                pausePanel.SetActive(false);
            }
            else if(Input.GetKeyDown(KeyCode.Q))
            {

                Time.timeScale = 1;
                //get back to start menu scene
                SceneManager.LoadScene(sceneName: "StartRoom");
            }
        }
        
    }

    public void onClick()
    {
        print("button clicked");
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }
}
