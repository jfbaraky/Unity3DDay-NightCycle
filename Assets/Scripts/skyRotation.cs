using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyRotation : MonoBehaviour
{
   public Vector3 rotationSpeed;
   public float cycleSpeed;
    void Start()
    {
      
    }


    void Update()
    {
          transform.Rotate(rotationSpeed* Time.deltaTime);
    }
}
