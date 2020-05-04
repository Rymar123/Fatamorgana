using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionDog : MonoBehaviour
{

    public GameObject dog;

    float x = -0.278f;
    float xx = 0.0001f;

    void Update()
    {

      
      /*  dog.transform.position += transform.up * Time.deltaTime * 0.0001f;

        dog.transform.position -= transform.forward * Time.deltaTime * 0.005f;

        dog.transform.position += transform.right * Time.deltaTime * 0.005f;


        dog.transform.position -= transform.up * Time.deltaTime * 0.0001f;

        dog.transform.position += transform.forward * Time.deltaTime * 0.005f;

        dog.transform.position -= transform.right * Time.deltaTime * 0.005f;*/



        transform.Translate(0.0001f, 0, 0);

      //  transform.Rotate(new Vector3(0.0001f, 0, 0));
          new WaitForSeconds(1);



        if (x >= -0.290f)
        {

            transform.Rotate(new Vector3(0, 180, 0));
            xx = -0.0001f; 
        }
        else if(x<-0.309f) {
            transform.Rotate(new Vector3(0, 180, 0));
            xx = 0.0001f;


        }

        x += xx;



        /*  transform.Rotate(new Vector3(0, 180, 0));


      float timePassed = 0;
      while (timePassed < 3)
      {
          //  transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 180, 0), speed * Time.deltaTime);

          timePassed += Time.deltaTime;
      }
      transform.Translate(-0.05f, 0, 0);
      new WaitForSeconds(1);
      transform.Translate(0, -0.7f, 0);
      transform.Rotate(new Vector3(0, -0.7f, 0));*/




    }

}

