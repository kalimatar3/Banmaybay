using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class MainMenu : MonoBehaviour {

    protected void Awake() {
        transform.Find("StartButton").GetComponent<Button_UI>().ClickFunc = () => {
            Loader.Load(Loader.Scene.GamePlay);
        };
    }

}
