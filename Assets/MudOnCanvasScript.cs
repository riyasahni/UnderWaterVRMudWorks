using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MudOnCanvasScript : MonoBehaviour
{
    public Text TextToCheckThatMudToggleIsOn;
    public GameObject mudPlane;

    // Start is called before the first frame update
    void Start()
    {
        mudPlane.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(TextToCheckThatMudToggleIsOn.text == "on"){
            mudPlane.SetActive(true);
        }
        if(TextToCheckThatMudToggleIsOn.text == "off"){
            mudPlane.SetActive(false);
        }

    }
}
