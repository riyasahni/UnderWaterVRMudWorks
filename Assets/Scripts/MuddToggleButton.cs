using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuddToggleButton : MonoBehaviour
{
    //public bool MuddToggleOn = false;
    public Text TextToCheckThatMudToggleIsOn;
    public GameObject MudButton;
    public GameObject MudButtonClose;
    public GameObject MUDVIEW;
    public GameObject CrewName1MUD;
    public GameObject CrewName2MUD;
    public GameObject CrewName3MUD;

    //TextToCheckThatMudToggleIsOn.text = "off"
    
    // Start is called before the first frame update
    public void ChangeMudToggle(){
        //MuddToggleOn=!MuddToggleOn;
        if(MUDVIEW.activeSelf == true){
            TextToCheckThatMudToggleIsOn.text = "on";
        } else
        {
            TextToCheckThatMudToggleIsOn.text = "off";
        }
        /*if(TextToCheckThatMudToggleIsOn.text == "on"){
            /*
            if(CrewName1MUD != null){
                CrewName1MUD.SetActive(true);
            }
            if(CrewName2MUD != null){
            CrewName2MUD.SetActive(true);
            }
            if(CrewName3MUD != null){
            CrewName3MUD.SetActive(true);
            }
            TextToCheckThatMudToggleIsOn.text = "off";
        }else{
            TextToCheckThatMudToggleIsOn.text = "on";
        }*/
    }
}
