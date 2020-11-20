using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour {
    public void ExitApplication () {
        UnityEngine.Debug.LogError ("Exit");
        Application.Quit();
    }
}