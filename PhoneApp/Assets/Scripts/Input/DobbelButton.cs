using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DobbelButton : MonoBehaviour {
    private Dobbel dobbel;
    [SerializeField] private GameObject _dobbelObject;
    // Use this for initialization
    void Start () {
        dobbel = _dobbelObject.GetComponent<Dobbel>();
    }
    void _dobbellen()
    {
        dobbel.ClickDobbel();
    }
}
