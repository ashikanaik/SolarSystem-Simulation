using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosingUI : MonoBehaviour {
    [SerializeField]
    public GameObject SunPan;
    [SerializeField]
    public GameObject MarsPan;
    [SerializeField]
    public GameObject MercuryPan;
    [SerializeField]
    public GameObject VenusPan;
    [SerializeField]
    public GameObject EarthPan;
    [SerializeField]
    public GameObject MoonPan;
    [SerializeField]
    public GameObject JupiterPan;
    [SerializeField]
    public GameObject SaturnPan;
    [SerializeField]
    public GameObject UranusPan;
    [SerializeField]
    public GameObject NeptunePan;
    [SerializeField]
    public GameObject PlutoPan;
    void OnMouseDown () {
        SunPan.SetActive (false);
        MarsPan.SetActive (false);
        MercuryPan.SetActive (false);
        VenusPan.SetActive (false);
        EarthPan.SetActive (false);
        MoonPan.SetActive (false);
        JupiterPan.SetActive (false);
        SaturnPan.SetActive (false);
        UranusPan.SetActive (false);
        NeptunePan.SetActive (false);
        PlutoPan.SetActive (false);
    }
}