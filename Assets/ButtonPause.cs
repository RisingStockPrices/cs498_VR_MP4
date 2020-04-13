using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPause : MonoBehaviour
{
    public GameObject pausePanel;
    // Start is called before the first frame update
  

    public void onClick()
    {
        print("button clicked");
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }
}
