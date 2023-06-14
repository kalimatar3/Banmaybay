using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
public class LastScene : MonoBehaviour
{
    protected void Awake() {
        transform.Find("RetryButton").GetComponent<Button_UI>().ClickFunc = () => {
            Loader.Load(Loader.Scene.GamePlay);
        };
    }
}
