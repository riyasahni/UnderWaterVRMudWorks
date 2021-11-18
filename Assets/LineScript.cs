using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LineScript : MonoBehaviour
{
    public LineRenderer line;
    public InformationManager iM;
    public CallTowerManager ctm;
    public Transform I_trf;
    public Text TextToStoreSelectedButtonState;
    public Text TextToStoreNavigationOn;
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
        if (TextToStoreNavigationOn.text == "true"){
            line.enabled = true;
            if (TextToStoreSelectedButtonState.text == "0")  { //&& TextToStoreNavigationOn.text == "true"
                line.SetPosition(0,I_trf.position);
                line.SetPosition(1,ctm.crewmates[0].position);
            }
            else if (TextToStoreSelectedButtonState.text == "1") { //&& TextToStoreNavigationOn.text == "true"
                line.SetPosition(0,I_trf.position);
                line.SetPosition(1,ctm.crewmates[1].position);
            }
            else if (TextToStoreSelectedButtonState.text == "2") { //&& TextToStoreNavigationOn.text == "true"
                line.SetPosition(0,I_trf.position);
                line.SetPosition(1,ctm.crewmates[2].position);
            }
        } else {
            line.enabled = false; 
        }
    }
}



/*using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LineScript : MonoBehaviour
{
    public LineRenderer line;
    public InformationManager iM;
    public CallTowerManager ctm;
    public Transform I_trf;
    public Text TextToStoreSelectedButtonState;
    public Text TextToStoreNavigationOn;
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
        if(TextToStoreNavigationOn.text == "true")
        {
            line.enabled = true;
            else if (TextToStoreSelectedButtonState.text == "0" && )  {
                line.SetPosition(0,I_trf.position);
                line.SetPosition(1,ctm.crewmates[0].position);
            }
            else if (TextToStoreSelectedButtonState.text == "1" ) {
                line.SetPosition(0,I_trf.position);
                line.SetPosition(1,ctm.crewmates[1].position);
            }
            else if (TextToStoreSelectedButtonState.text == "2") {
                line.SetPosition(0,I_trf.position);
                line.SetPosition(1,ctm.crewmates[2].position);
            }
        }else{
            line.enabled = false;
        }
        
    }
}
*/