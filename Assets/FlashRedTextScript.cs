using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FlashRedTextScript : MonoBehaviour
{
    public Text FlashRedText;
    public InformationManager iM;
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (iM.GetOxygenLevel() <= 15f) 
        {
            FlashRedText.text = "Low O2!"; 
            
            /*
            timer += Time.deltaTime;
            if(timer > 1.0f)
            {
                FlashRedText.text = "";
                //timer = 0.0f;
            }
            // turn it off after the flash goes away
            */
        }
        if(iM.GetOxygenLevel() > 15f)
        {
            FlashRedText.text = "";
        }
    }
}
