using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Solar_system");
    }
    public void toQuitGame()
    {
        SceneManager.LoadSceneAsync("exit");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}