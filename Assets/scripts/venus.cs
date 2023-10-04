using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class venus : MonoBehaviour
{
    public void OnMouseUpAsButton()
    {
        SceneManager.LoadSceneAsync("venus");
    }
}