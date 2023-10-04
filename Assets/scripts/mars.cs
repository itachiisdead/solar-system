using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mars : MonoBehaviour
{
    public void OnMouseUpAsButton()
    {
        SceneManager.LoadSceneAsync("mars");
    }
}
