using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            MainMenu();
        }
    }

    public void SceneReloader()
    {
        //Scene currentScene = SceneManager.GetActiveScene();
        //int currentSceneBuildIndex = currentScene.buildIndex;
        SceneManager.LoadScene(1);
    }

     public void EndScene()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
