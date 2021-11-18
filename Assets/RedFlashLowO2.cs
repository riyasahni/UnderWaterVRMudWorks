
using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RedFlashLowO2 : MonoBehaviour
{
    public GameObject redPlaneOxygen;
    public GameObject redPlaneBattery;
    public InformationManager iM;
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        redPlaneOxygen.SetActive(false);
        redPlaneBattery.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        if(iM.GetOxygenLevel() <= 15.0f )
        {
            redPlaneOxygen.SetActive(true);
        }
        if(iM.GetOxygenLevel() > 15.0f)
        {
            redPlaneOxygen.SetActive(false);
        }
        if(iM.GetBatteryLevel() <= 15.0f )
        {
            redPlaneBattery.SetActive(true);
        }

    }
}


