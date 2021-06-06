using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatChecker : MonoBehaviour
{  
   public FloatingScript floatingScript;
    void Start()
    {
        floatingScript = GetComponentInParent<FloatingScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other) {
        if(other.tag == "Player")
        {
            floatingScript.FloatEnabler();
        }   
    }
}
