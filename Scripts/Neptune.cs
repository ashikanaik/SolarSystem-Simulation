using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neptune : MonoBehaviour {
    [SerializeField]
    public GameObject NeptunePanel;

    void OnMouseDown () {
        StartCoroutine (NeptuneInfo ());
    }

    IEnumerator NeptuneInfo () {

        NeptunePanel.SetActive (true);
        yield return new WaitForSeconds (4.0f);
        // NeptunePanel.SetActive (false);

    }
}