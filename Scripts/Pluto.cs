using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pluto : MonoBehaviour {
    [SerializeField]
    public GameObject PlutoPanel;

    void OnMouseDown () {
        StartCoroutine (PlutoInfo ());
    }

    IEnumerator PlutoInfo () {

        PlutoPanel.SetActive (true);
        yield return new WaitForSeconds (4.0f);
        // PlutoPanel.SetActive (false);

    }
}