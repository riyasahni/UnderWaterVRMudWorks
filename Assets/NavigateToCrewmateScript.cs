using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NavigateToCrewmateScript : MonoBehaviour
{
    public Text TextToStoreSelectedButtonState;

    public LineRenderer line;
    public InformationManager iM;
    public CallTowerManager ctm;
    public Transform I_trf;
    public GameObject NavigateToButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Tranform a = iM.player.position;
        //Transform b = ctm.crewmates[0].position;
        //line.SetPosition(0,a);
        //line.SetPosition(1,b);

        // if (false) {

        //     line.SetPosition(0,I_trf.position);
        //     line.SetPosition(1,ctm.crewmates[0].position);
        // }
    }



}
