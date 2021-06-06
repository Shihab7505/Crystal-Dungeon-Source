using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MainHub : MonoBehaviour
{
    public int noOfCrystals = 0;
    [SerializeField] AudioClip coinPickupSFX;
    [SerializeField] TMP_Text crystalscore; 
    AudioSource audioSource;
    void Start()
    {
        crystalscore.text = 0.ToString();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCrystalScore(int amount)
    {
        noOfCrystals += amount;
        crystalscore.text = noOfCrystals.ToString();
        audioSource.PlayOneShot(coinPickupSFX,1);
        Debug.Log("You have collected" + "" + noOfCrystals + "" +" crystals");
    }
}
