using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyRotation : MonoBehaviour
{
   public Vector3 rotationSpeed;
   public skyDomeDayNight skyDomeDayNight;
    void Start()
    {
      
    }


    void Update()
    {
          transform.Rotate(rotationSpeed * skyDomeDayNight.cycleSpeed  * Time.deltaTime); //Leave the rotation speed on 360 for better timing
    }
}
