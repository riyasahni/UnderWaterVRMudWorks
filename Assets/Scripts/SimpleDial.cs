using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class SimpleDial : MonoBehaviour
{

    public CallTowerManager ctm;
    private AudioSource aS;
    private bool isBusy = false;
    private bool isIncomingCall = false;

    public AudioClip ringtone;
    private AudioClip incomingCall;
    private int incomingCallerFrequency = 0;

    public Text IncomingCallText; 
    public Text OnCallWithText; 
    public Text OnCallWithEmergency;

    private string PersonWhoIsCalling = "Don";
    private string PersonWeAreCalling = "Ishaan";

    public Text TextToStoreFrequencyOfSelectedCrewMate;


    void Start()
    {
        aS = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    public void QuickDial(int freq) // We are calling OUT 
    {
        if (!isBusy) // You need to hangup to make a call.
        {
            // cycle through crewmates to find name of crewmate to display 
            CrewInfo[] crewInformation = ctm.GetCrewmatesInformation();
            foreach(CrewInfo currCrewmate in crewInformation)
            {
                if (currCrewmate.frequency == freq) {
                    PersonWeAreCalling = currCrewmate.name;
                }
            }

            // Check if we are calling emergency
            if (freq == 1001) {
                OnCallWithEmergency.text = "On call with emergency";
            }
            else {
                string textToReplace = "On call with " + PersonWeAreCalling;
                OnCallWithText.text = textToReplace;
            }

            isBusy = true;
            aS.clip = ctm.CallCrewmate(freq);
            aS.Play();

        } 
    }

    public void QuickDialFast() // We are calling OUT 
    {
        if (!isBusy) // You need to hangup to make a call.
        {
            int freq = int.Parse(TextToStoreFrequencyOfSelectedCrewMate.text);
            // cycle through crewmates to find name of crewmate to display 
            CrewInfo[] crewInformation = ctm.GetCrewmatesInformation();
            foreach(CrewInfo currCrewmate in crewInformation)
            {
                if (currCrewmate.frequency == freq) {
                    PersonWeAreCalling = currCrewmate.name;
                }
            }

            // Check if we are calling emergency
            if (freq == 1001) {
                OnCallWithEmergency.text = "On call with emergency";
            }
            else {
                string textToReplace = "On call with " + PersonWeAreCalling;
                OnCallWithText.text = textToReplace;
            }

            isBusy = true;
            aS.clip = ctm.CallCrewmate(freq);
            aS.Play();

        } 
    }





    public bool IncomingCall(AudioClip speaker, int freq)
    {

        if (!isBusy && !isIncomingCall)
        {
            // Find Name of the crewmate to replace field with 
            CrewInfo[] crewInformation = ctm.GetCrewmatesInformation();

            foreach(CrewInfo currCrewmate in crewInformation)
            {
                if (currCrewmate.frequency == freq) {
                    PersonWhoIsCalling = currCrewmate.name;
                }
            }
            
            if (freq == 1001) {
                PersonWhoIsCalling = "Emergency";
            }

            //  modify the HUD 
            string textToReplace = "Incoming Call From " + PersonWhoIsCalling;
            IncomingCallText.text = textToReplace;

            incomingCall = speaker;
            incomingCallerFrequency = freq;
            isIncomingCall = true;
            isBusy = true;

            aS.clip = ringtone;
            aS.loop = true;
            aS.Play();
        }

        return !isBusy;

    }

    public void AnswerCall()
    {
        if (isIncomingCall)
        {
            aS.Stop();
            aS.loop = false;
            aS.clip = incomingCall;
            aS.Play();
            isIncomingCall = false;

            //  modify the HUD 
            IncomingCallText.text = ""; // we no longer have a call that is incoming 
            string textToReplace = "On call with " + PersonWhoIsCalling; 
            OnCallWithText.text = textToReplace;

        }
    }

    public void HangUp()
    {
        if (isBusy)
        {
            // Turn the text back to normal
            OnCallWithText.text = "";
            IncomingCallText.text = "";

            aS.Stop();
            isBusy = false;
            isIncomingCall = false;

            
        }
    }

    void Update() {
        // After we are done talking, need the on-screen text to dissappear for "on call with"...
        if (!aS.isPlaying) {
            OnCallWithText.text = "";
            OnCallWithEmergency.text = "";
        }
    }
}


