using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollecter : MonoBehaviour
{
    [SerializeField] int increase = 1;
    [SerializeField] MainHub mainHub;
    [SerializeField]GameObject smokePickup;
    [SerializeField] PowerUps powerUps;
    MeshRenderer meshRenderer;
    BoxCollider boxCollider;
    Light lightChild;

    void Start()
    {
        meshRenderer = GetComponentInChildren<MeshRenderer>();
        boxCollider = GetComponentInChildren<BoxCollider>();
        lightChild = GetComponentInChildren<Light>();

    }// Update is called once per frame

    void OnTriggerEnter(Collider other)
    {
        mainHub.UpdateCrystalScore(increase);
        powerUps.FindRandomMethod();
        meshRenderer.enabled = false;
        lightChild.enabled = false;
        boxCollider.enabled = false;
        smokePickup.SetActive(true);
        Invoke("Kill",2f);
        
    }

    private void Kill()
    {
        Destroy(gameObject);
    }
}