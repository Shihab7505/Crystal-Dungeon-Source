 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    public float delayTime;
    [SerializeField] Health health;
    [SerializeField] Animation SpikeAnimation;
    bool doneOnce = false;

   

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && !doneOnce)
        {
            SpikeAnimation.Play(); 
            health.DecreaseLife(1);
            doneOnce = true;
        }

        
    }

    void OnTriggerExit(Collider other) 
    {
        if(other.tag == "Player")
        {
            doneOnce = false;
        }    
    }

}
