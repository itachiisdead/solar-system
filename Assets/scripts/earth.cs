using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class earth : MonoBehaviour
{
    public void OnMouseUpAsButton()
    {
        SceneManager.LoadSceneAsync("earth");
    }
}