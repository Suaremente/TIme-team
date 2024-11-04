using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void goToScene(string sceneName) { 
        SceneManager.LoadScene(sceneName);
    
    }

    public void QuitApp() { 
        Application.Quit(); 
    }
}
