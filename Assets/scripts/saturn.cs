using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saturn : MonoBehaviour
{
    public void OnMouseUpAsButton()
    {
        SceneManager.LoadSceneAsync("saturn");
    }
}
