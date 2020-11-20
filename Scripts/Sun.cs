using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour {
    [SerializeField]
    public GameObject SunPanel;
   

    void OnMouseDown () {

        StartCoroutine (SunInfo ());
    }

    IEnumerator SunInfo () {
        
        SunPanel.SetActive (true);
        yield return new WaitForSeconds (4.0f);
        // SunPanel.SetActive (false);
       

    }
}