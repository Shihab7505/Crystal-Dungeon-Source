using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void EndScene()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
