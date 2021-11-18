using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RedFlashTextbatteryScript : MonoBehaviour
{
    public Text FlashRedText;
    public InformationManager iM;
    public GameObject BatteryLowScreen;
    private float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (iM.GetBatteryLevel() <= 15f) 
        {
            FlashRedText.text = "Low battery!"; 
            BatteryLowScreen.SetActive(true);
        }
    }
}
