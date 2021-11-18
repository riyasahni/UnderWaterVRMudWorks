using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeStateOfSelectedButton : MonoBehaviour
{
    public Text TextToStoreNavigationOn;

    public void changeTextState() {
        if (TextToStoreNavigationOn.text == "true") {
            TextToStoreNavigationOn.text = "false";
        } else {
            TextToStoreNavigationOn.text = "true";
        }
    }
}
