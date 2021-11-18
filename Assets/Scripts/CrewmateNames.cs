using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrewmateNames : MonoBehaviour
{
    public PanelOpener panel;


    public CallTowerManager ctm;
    public Button CrewName1;
    public Button CrewName2;
    public Button CrewName3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CrewInfo[] crewInformation = ctm.GetCrewmatesInformation();
        string crewText1 = "";
        string currName1 = crewInformation[0].name;
        crewText1 = currName1;
        CrewName1.GetComponentInChildren<Text>().text = crewText1;

        string crewText2 = "";
        string currName2 = crewInformation[1].name;
        crewText2 = currName2;
        CrewName2.GetComponentInChildren<Text>().text = crewText2;

        string crewText3 = "";
        string currName3 = crewInformation[2].name;
        crewText3 = currName3;
        CrewName3.GetComponentInChildren<Text>().text = crewText3;        
    }
}
