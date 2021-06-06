using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectChecker : MonoBehaviour
{
    MeshRenderer meshRenderer;

    void Start() 
    {
        meshRenderer = GetComponent<MeshRenderer>();    
    }
   void OnTriggerStay(Collider other) 
   {
        if(other.tag == "Player")
        {
            gameObject.SetActive(true);
        }    
   }

   void OnTriggerExit(Collider other) 
   {
        gameObject.SetActive(false);    
   }
}
