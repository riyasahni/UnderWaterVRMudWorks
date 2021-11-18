using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MudViewPanelText : MonoBehaviour
{
    public CallTowerManager ctm;
    public GameObject CrewName1MUD;
    public GameObject CrewName2MUD;
    public GameObject CrewName3MUD;
    // Start is called before the first frame update
    void Start()
    {
    string loc = "Loc: ";
    string freqNum = "Frequency #: ";
    CrewInfo[] crewPosition = ctm.GetCrewmatesInformation();
    string Crew1MudPanelText =  crewPosition[0].worldLocation.ToString();
    string Crew1MudPanelFreqNum = crewPosition[0].frequency.ToString();
    string Crew1MudPanelName = "Pedro: ";
    string Crew2MudPanelText =  crewPosition[1].worldLocation.ToString();
    string Crew2MudPanelFreqNum = crewPosition[1].frequency.ToString();
    string Crew2MudPanelName = "Romain: ";
    string Crew3MudPanelText =  crewPosition[2].worldLocation.ToString();
    string Crew3MudPanelFreqNum = crewPosition[2].frequency.ToString();
    string Crew3MudPanelName = "Suzie: ";
    CrewName1MUD.GetComponentInChildren<Text>().text = Crew1MudPanelName + loc + Crew1MudPanelText + "\n" + freqNum + Crew1MudPanelFreqNum;
//Only the first line here is rendering for some reason...
  
    CrewName2MUD.GetComponentInChildren<Text>().text = Crew2MudPanelName + loc + Crew2MudPanelText + "\n" + freqNum + Crew2MudPanelFreqNum;
    CrewName3MUD.GetComponentInChildren<Text>().text = Crew3MudPanelName + loc + Crew3MudPanelText + "\n" + freqNum + Crew3MudPanelFreqNum;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
