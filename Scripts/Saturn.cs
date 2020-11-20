using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saturn : MonoBehaviour {
    [SerializeField]
    public GameObject SaturnPanel;

    void OnMouseDown () {
        StartCoroutine (SaturnInfo ());
    }

    IEnumerator SaturnInfo () {

        SaturnPanel.SetActive (true);
        yield return new WaitForSeconds (4.0f);
        // SaturnPanel.SetActive (false);

    }
}