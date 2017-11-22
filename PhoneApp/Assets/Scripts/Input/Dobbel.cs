using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dobbel : MonoBehaviour {
    public int randomGetal = 1;

    [HideInInspector]
    public Text dobbelText;

    [SerializeField]
    private GameObject dobbelTextObject;
    // Use this for initialization
    void Start () {
        dobbelText = dobbelTextObject.GetComponent<Text>();   
    }
	
	// Update is called once per frame
	public void ClickDobbel () {
            randomGetal = Random.Range(1, 7);
            dobbelText.text = "You Rolled:" + randomGetal;
            Debug.Log(randomGetal);
    }
}
