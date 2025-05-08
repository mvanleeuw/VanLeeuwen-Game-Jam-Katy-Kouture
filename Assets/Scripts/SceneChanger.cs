using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string SceneName;

    void Start()
    {

    }

    // Switches to scene typed in Unity
    void Update() {

        if (Input.GetKey(KeyCode.S))
        {
            SceneManager.LoadScene(SceneName);
        }

    }

    // Allows for when button is clicked, new scene is loaded
    public void ChangeLevel(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
