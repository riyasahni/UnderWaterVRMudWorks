using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using Math;

public class GetDepth : MonoBehaviour
{

    // public CallTowerManager ctm;
    public InformationManager iM;
    public Text currDepth;

    // Start is called before the first frame update
    void Start()
    {
        // textBox = this.GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        // string depthText = Math.Round(iM.GetDepth().ToString(), 2);
        string depthText = iM.GetDepth().ToString();
        currDepth.text = Mathf.Round(iM.GetDepth()).ToString() + "m";
    }
}
