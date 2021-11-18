using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// how to change color of the bar? We tried following this: https://answers.unity.com/questions/861100/unity-46-how-to-change-slider-color-via-script.html
// public Image Fill;

[RequireComponent(typeof(Slider))]
public class OxygenBar : MonoBehaviour
{

    private Slider slider;
    public InformationManager iM;
    public Text currOxygen; 

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        SetMaxOxygenLevel(iM.GetMaxOxygenLevel());
    }

    public void SetMaxOxygenLevel (float maxLevel)
    {
        slider.maxValue = maxLevel;
        slider.value = maxLevel; // Start with max!
    }

    public void SetOxygenLevel (float level)
    {
        slider.value = level;
    }

    private void Update()
    {
        SetOxygenLevel(iM.GetOxygenLevel());
        currOxygen.text = Mathf.Round(iM.GetOxygenLevel()).ToString();

        // updateSliderColor(iM.GetOxygenLevel());
        // Debug.Log("Current oxygen level: ", iM.GetOxygenLevel());
    }

    // public void updateSliderColor(float currOxygen) {
    //     Color color = new Color(233f/255f, 79f/255f, 55f/255f);
    //     Fill.color = color;
    // }

}
