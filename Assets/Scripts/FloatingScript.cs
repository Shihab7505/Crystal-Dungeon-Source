using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingScript : MonoBehaviour
{
    [SerializeField] Vector3 startPos;
    [SerializeField] float speed = .6f;
    [SerializeField] Vector3 endPos;
    [SerializeField] float rotateAmount = 1f;
    GameObject crystalChild;
    
    void Start()
    {
        startPos = gameObject.transform.position;
        crystalChild = GetComponentInChildren<MeshRenderer>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void FloatEnabler()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(startPos, endPos, time);
        crystalChild.transform.Rotate(Vector3.forward * rotateAmount);
    }
}
