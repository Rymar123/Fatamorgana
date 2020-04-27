using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionDog : MonoBehaviour
{

    public GameObject dog;

    void Update()
    {
      
        dog.transform.position += transform.up * Time.deltaTime * 0.0001f;

        dog.transform.position -= transform.forward * Time.deltaTime * 0.005f;

        dog.transform.position += transform.right * Time.deltaTime * 0.005f;
  

    }

}

