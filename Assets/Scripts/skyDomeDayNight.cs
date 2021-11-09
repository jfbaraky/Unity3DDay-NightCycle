using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyDomeDayNight : MonoBehaviour
{
    private Material material;
    [Header("Sky Assets Settings")] //Set the moon, starts and sun objects
    public GameObject Moon;
    public GameObject Stars;
    public GameObject Sun;
    [Header("Sky Movement Systems")]
    public float cycleSpeed; //Set how fast the night and day cycle will be by changing the offSet
     private float offSet; //Set how the Cycle will start
    void Start()
    {
        material = GetComponent<Renderer>().material; // Gets the material of the Sky
    }

  
    void Update()
    {
       CycleDay();
       MoonAndSun();

    }
    void CycleDay(){ // Day and Night Cycle
         offSet += cycleSpeed * Time.deltaTime; 
        material.SetTextureOffset("_MainTex" , new Vector2(offSet, 0));   // Increase the offset of the object in a certain rate 
        if(offSet >= 1){
            offSet = 0;
        }
    }
    void MoonAndSun(){ 
        if(offSet >= 0.2 && offSet <= 0.7){
            Moon.SetActive(true);
            Stars.SetActive(true);
            Sun.SetActive(false);
        } 
        else{
             Moon.SetActive(false);
            Stars.SetActive(false);
            Sun.SetActive(true);
        }

    }
}
