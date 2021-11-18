using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//edit
using UnityEngine.UI;
//edit

public class PanelOpener : MonoBehaviour
//create different panels for different buttons!
{
    public GameObject Crew1InfoPanel;
    public GameObject Crew2InfoPanel;
    public GameObject Crew3InfoPanel;
    public GameObject MUDVIEW;
    
   /* public GameObject CrewName1MUD;
    public GameObject CrewName2MUD;
    public GameObject CrewName3MUD;*/
  //  public GameObject CrewName1MUD;
  //  public Text TextToCheckThatMudToggleIsOn;
    public Text TextToStoreSelectedButtonState;
    public Text TextToStoreFrequencyOfSelectedCrewMate;
    public CallTowerManager ctm;
    private bool mudViewOn = false;
 //   Crew1Mud = MUDVIEW.GetChild(0).GameObject;
    // Start is called before the first frame update


    public void OpenPanel()
    {
        
        // cycle through crewmates to find name of crewmate to display 
        CrewInfo[] crewInformation = ctm.GetCrewmatesInformation();
        // foreach(CrewInfo currCrewmate in crewInformation)
        // {
        //     if (currCrewmate.frequency == freq) {
        //         PersonWeAreCalling = currCrewmate.name;
        //     }
        // }
        /*
        if(TextToCheckThatMudToggleIsOn.text=="on"){
            if(CrewName1MUD != null){
                CrewName1MUD.SetActive(true);
            }
            if(CrewName2MUD != null){
            CrewName2MUD.SetActive(true);
            }
            if(CrewName3MUD != null){
            CrewName3MUD.SetActive(true);
            }
        } else {
            if(CrewName1MUD != null){
                CrewName1MUD.SetActive(false);
            }
            if(CrewName2MUD != null){
            CrewName2MUD.SetActive(false);
            }
            if(CrewName3MUD != null){
            CrewName3MUD.SetActive(false);
            }
        }*/   
        
     
      



        if(Crew1InfoPanel != null)
        {
            // edit
            TextToStoreSelectedButtonState.text = "0";
            TextToStoreFrequencyOfSelectedCrewMate.text = crewInformation[0].frequency.ToString();
            // edit    
            Crew1InfoPanel.SetActive(true);
            if(mudViewOn)
            {
                MUDVIEW.transform.GetChild(0).gameObject.GetComponent<Image>().color = new Color32(183, 0, 255, 100);
            }
        }
        
        if(Crew2InfoPanel != null)
        {
            // edit
            TextToStoreSelectedButtonState.text = "1";
            TextToStoreFrequencyOfSelectedCrewMate.text = crewInformation[1].frequency.ToString();
            // edit
            Crew2InfoPanel.SetActive(true);
        }

        if(Crew3InfoPanel != null)
        {
            // edit
            TextToStoreSelectedButtonState.text = "2";
            TextToStoreFrequencyOfSelectedCrewMate.text = crewInformation[2].frequency.ToString();
            // edit
            Crew3InfoPanel.SetActive(true);
        }

      if(MUDVIEW != null){
            MUDVIEW.SetActive(true);
            mudViewOn = true;
        //    MUDVIEW.transform.GetChild(0).gameObject.GetComponent<Image>().color = new Color32(183, 0, 255, 100);
               
        }

    }


    public void ClosePanel()
    {

        if(MUDVIEW != null){
                MUDVIEW.SetActive(false);
        }
        if(Crew1InfoPanel != null)
        {
            Crew1InfoPanel.SetActive(false);
        }
        
        if(Crew2InfoPanel != null)
        {
            Crew2InfoPanel.SetActive(false);
        }

        if(Crew3InfoPanel != null)
        {
            Crew3InfoPanel.SetActive(false);
        }

    }
}
