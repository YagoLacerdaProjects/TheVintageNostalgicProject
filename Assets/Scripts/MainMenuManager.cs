using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void loadLevel(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
