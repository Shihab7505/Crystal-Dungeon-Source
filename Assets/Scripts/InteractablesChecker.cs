using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractablesChecker : MonoBehaviour
{
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Interactables")
        {
            other.gameObject.SetActive(true);        }
    }
}
