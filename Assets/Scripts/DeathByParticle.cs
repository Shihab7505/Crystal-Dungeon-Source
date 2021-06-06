using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathByParticle : MonoBehaviour
{
    [SerializeField] Health health;
    [SerializeField] float safetyPeriod  = 1f;
    [SerializeField] float timeTillNextKill = 0f;
    void Start()
    {

    }

    void OnParticleCollision(GameObject other)
    {
        
        if(Time.time > timeTillNextKill)
        {
            health.DecreaseLife(1);
            timeTillNextKill = Time.time + safetyPeriod; 
        }    
    }
}


