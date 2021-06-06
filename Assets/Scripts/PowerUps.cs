using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUps : MonoBehaviour
{
    [SerializeField] GameObject SpeedIcon;
    [SerializeField] GameObject SlownessIcon;
    [SerializeField] GameObject HeartGainIcon;
    [SerializeField] GameObject HeartLossIcon;
    [SerializeField] GameObject NightVisionIcon;
    [SerializeField]GameObject  FlashlightDecreaseIcon;
    [SerializeField] GameObject FlashlightIncreaseIcon;
    [SerializeField] PlayerController playerController;
    [SerializeField] GameObject nightVision;
    [SerializeField] GameObject directionalLight;
    float RandomNo;
    float ogIntensity = 3;
    [SerializeField]Health health;
    FlashlightScript flashlightScript;
    Light flashlight;
    void Start()
    {
        flashlightScript = GetComponent<FlashlightScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FindRandomMethod()
    {
        RandomNo = Random.Range(1f,80f);
        
        if(RandomNo <=10 && RandomNo >=1)
        {
            StartCoroutine(SpeedBoost());
            Debug.Log("You picked up Effect 1");
        }
        else if(RandomNo <=20 && RandomNo >=11)
        {
            StartCoroutine(SlownessEffect());
            Debug.Log("You picked up Effect 2");
        }
        else if(RandomNo <=30 && RandomNo >=21)
        {
            Debug.Log("You picked up Effect 3");
            StartCoroutine(HeartBoost()); // this is instant heath so no coroutine
        }
        else if(RandomNo <=40 && RandomNo >=31)
        {
            if(health.livesRemaining != 1) {StartCoroutine(HeartLoss());}
            Debug.Log("You picked up Effect 4");
        }
        else if(RandomNo <=50 && RandomNo >=41)
        {
            StartCoroutine(FlashlightBoost());
            Debug.Log("You picked up Effect 5");
        }
        else if(RandomNo <=60 && RandomNo >=51)
        {
            StartCoroutine(FlashlightIntensityDecrease());
            Debug.Log("You picked up Effect 6");
        }
        else if(RandomNo <=70 && RandomNo >=61)
        {
            StartCoroutine(NightVision());
            Debug.Log("You picked up Effect 7");
        }
        else if(RandomNo <=80 && RandomNo >=71)
        {
            Debug.Log("You picked up Effect 8");
        }
    }

    IEnumerator NightVision()
    {
        NightVisionIcon.SetActive(true);
        nightVision.SetActive(true);
        directionalLight.SetActive(true);
        int timer = Random.Range(15,45);
        yield return new WaitForSeconds(timer);
        nightVision.SetActive(false);
        NightVisionIcon.SetActive(false);
        directionalLight.SetActive(false);

    }

    IEnumerator FlashlightIntensityDecrease()
    {
        FlashlightDecreaseIcon.SetActive(true);
        float flickeringIntensity = Random.Range(0.2f,ogIntensity);
        flashlight = flashlightScript.lightComponent.GetComponent<Light>();
        int intensityTimer = Random.Range(5,25);
        flashlight.intensity = flickeringIntensity;
        yield return new WaitForSeconds(intensityTimer);
        flashlight.intensity = ogIntensity;
        FlashlightDecreaseIcon.SetActive(false);
     
        
    }

    IEnumerator FlashlightBoost()
    {
        if(flashlightScript.staminaBar.value < 100)
        {
            float barIncrease = Random.Range(1f, flashlightScript.maxStamina - flashlightScript.currentStamina);
            flashlightScript.staminaBar.value += barIncrease;
            flashlightScript.currentStamina = flashlightScript.staminaBar.value;
        }
        FlashlightIncreaseIcon.SetActive(true);
        yield return new WaitForSeconds(2f);
        FlashlightIncreaseIcon.SetActive(false);
    }

    IEnumerator HeartLoss()
    {
        if(health.livesRemaining > 0)
        {
            int heartdecrease = Random.Range(1, health.livesRemaining -1);
            health.DecreaseLife(heartdecrease);
        }
        HeartLossIcon.SetActive(true);
        yield return new WaitForSeconds(2f);
        HeartLossIcon.SetActive(false);
    }

    IEnumerator HeartBoost()
    {   
        Debug.Log("GET HEALTEHD BICH");
        if(health.livesRemaining < 10)
        {
            int heartIncrease = Random.Range(1, health.livesRemaining);
            health.IncreaseLife(heartIncrease);      
        }
        HeartGainIcon.SetActive(true);
        yield return new WaitForSeconds(2f);
        HeartGainIcon.SetActive(false);
       
    } 

    IEnumerator SlownessEffect()
    {
        SlownessIcon.SetActive(true);
        playerController.walkSpeed = 4f;
        float speedTimer = Random.Range(15f,50f);
        yield return new WaitForSeconds(speedTimer);
        SlownessIcon.SetActive(false);
        playerController.walkSpeed = 10f;
    }

    IEnumerator SpeedBoost()
    {
        SpeedIcon.SetActive(true);
        playerController.walkSpeed = 20f;
        float speedTimer = Random.Range(25f,40f);
        yield return new WaitForSeconds(speedTimer);
        SpeedIcon.SetActive(false);
        playerController.walkSpeed = 10f;
    }
}

