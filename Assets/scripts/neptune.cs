using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class neptune : MonoBehaviour
{
    public void OnMouseUpAsButton()
    {
        SceneManager.LoadSceneAsync("neptune");
    }
}