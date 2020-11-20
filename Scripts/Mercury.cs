using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercury : MonoBehaviour {
    [SerializeField]
    public GameObject MercuryPanel;

    void OnMouseDown () {
        StartCoroutine (MercuryInfo ());
    }

    IEnumerator MercuryInfo () {

        MercuryPanel.SetActive (true);
        yield return new WaitForSeconds (4.0f);
        // MercuryPanel.SetActive (false);

    }
}