using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTime : MonoBehaviour
{
    private float timer = 0.0f;
    public Text currTime;
    public InformationManager iM;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // only increment timer if we are underwater
        if (iM.GetDepth() < 0.0) {
            timer += Time.deltaTime;

        }

        float totalSecsPassed = Mathf.Round(timer); 
        int minutes = (int) Mathf.Floor(totalSecsPassed / 60);

        int seconds = (int) Mathf.Floor(totalSecsPassed % 60);
        string timeToShow;

        string strSeconds = seconds.ToString();
        string strMinutes = minutes.ToString();

        if (strSeconds.Length <= 1) {
            strSeconds = "0" + strSeconds;
        }
        if (strMinutes.Length <= 1) {
            strMinutes = "0" + strMinutes;
        }

        timeToShow = strMinutes + ":" + strSeconds;

        currTime.text = timeToShow;

        
    }
}
