using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// how to change color of the bar? We tried following this: https://answers.unity.com/questions/861100/unity-46-how-to-change-slider-color-via-script.html
// public Image Fill;

[RequireComponent(typeof(Slider))]
public class BatteryBar : MonoBehaviour
{

    private Slider slider;
    public InformationManager iM;
    public Text currBattery; 

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        SetMaxBatterLevel(iM.GetMaxBatteryLevel());
    }

    public void SetMaxBatterLevel (float maxLevel)
    {
        slider.maxValue = maxLevel;
        slider.value = maxLevel; // Start with max!
    }

    public void SetBatteryLevel (float level)
    {
        slider.value = level;
    }

    private void Update()
    {
        float currBatteryLevel = iM.GetBatteryLevel();
        // Debug.Log(currBatteryLevel.ToString());

        SetBatteryLevel(iM.GetBatteryLevel());
        currBattery.text = Mathf.Round(iM.GetBatteryLevel()).ToString();

        // updateSliderColor(iM.GetOxygenLevel());
    }

    // public void updateSliderColor(float currOxygen) {
    //     Color color = new Color(233f/255f, 79f/255f, 55f/255f);
    //     Fill.color = color;
    // }

}
