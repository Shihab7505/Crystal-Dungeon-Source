using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    [SerializeField]Health health;
    float timeTillNextKill = 0f;
    bool isCalled = false;
    bool isActive = false;
    [SerializeField] float intervalTime = 2f;
    //GameObject emissionVFX;
    ParticleSystem emissionFX;

    [SerializeField] float safetyperiod = 1f;   
    void Start()
    {
        //emissionVFX = GetComponent<ParticleSystem>().gameObject;
        emissionFX = GetComponent<ParticleSystem>();

        InvokeRepeating("EffectIntervals",1,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnParticleCollision(GameObject other) 
    {
      if(Time.time > timeTillNextKill)
      {
        health.DecreaseLife(1);
        timeTillNextKill = Time.time + safetyperiod;

      }
    }

    void EffectIntervals()
    {
        var PP = emissionFX.emission;
        PP.enabled = !PP.enabled;
        //emissionVFX.SetActive(!emissionVFX.activeInHierarchy);
    }
}
