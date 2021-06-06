using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneEnd : MonoBehaviour
{
    [SerializeField]GameObject defaultCanvas;
    [SerializeField] GameObject endCanvas;
    [SerializeField] PlayerController playerController;
    [SerializeField] FlashlightScript flashlightScript;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Player")
        {
            defaultCanvas.SetActive(false);
            endCanvas.SetActive(true);
            playerController.enabled = false;
            flashlightScript.enabled = false;
        }
    }
}

