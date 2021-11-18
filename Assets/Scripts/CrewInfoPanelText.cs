using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrewInfoPanelText : MonoBehaviour
{
    public CallTowerManager ctm;
    public GameObject Crew1InfoPanel;
    public GameObject Crew2InfoPanel;
    public GameObject Crew3InfoPanel;
    // Start is called before the first frame update
 //   private Text txt;


    void Start()
    {
    string loc = "Crewmate's Location: ";
    string freqNum = "Crewmate's Frequency #: ";
    CrewInfo[] crewPosition = ctm.GetCrewmatesInformation();
    string Crew1PanelText =  crewPosition[0].worldLocation.ToString();
    string Crew1PanelFreqNum = crewPosition[0].frequency.ToString();
    string Crew2PanelText =  crewPosition[1].worldLocation.ToString();
    string Crew2PanelFreqNum = crewPosition[1].frequency.ToString();
    string Crew3PanelText =  crewPosition[2].worldLocation.ToString();
    string Crew3PanelFreqNum = crewPosition[2].frequency.ToString();
    Crew1InfoPanel.GetComponentInChildren<Text>().text = loc + Crew1PanelText + "\n" + freqNum + Crew1PanelFreqNum;
//Only the first line here is rendering for some reason...
  
    Crew2InfoPanel.GetComponentInChildren<Text>().text = loc + Crew2PanelText + "\n" + freqNum + Crew2PanelFreqNum;
    Crew3InfoPanel.GetComponentInChildren<Text>().text = loc + Crew3PanelText + "\n" + freqNum + Crew3PanelFreqNum;
         //CrewInfo[] crewPosition = ctm.GetCrewmatesInformation();
     //   Crew1InfoPanel.GetComponent<Text>() = "hi";

    }

    void update()
    {

    //    txt.text = "Loc: " + Crew1PanelText;
    /*    Crew1InfoPanel.GetComponent<Text>().text = Crew1PanelText;

        string Crew2PanelText = "";
        string Crew2Pos =  crewPosition[1].worldLocation.ToString();
        Crew2PanelText = Crew1PanelText + Crew2Pos;
        Crew2InfoPanel.GetComponent<Text>().text = Crew2PanelText;

        string Crew3PanelText = "";
        string Crew3Pos =  crewPosition[2].worldLocation.ToString();
        Crew3PanelText = Crew3PanelText + Crew3Pos;
        Crew3InfoPanel.GetComponent<Text>().text = Crew3PanelText;*/
    }
    // Update is called once per frame

}
