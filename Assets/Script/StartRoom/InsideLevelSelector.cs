using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideLevelSelector : MonoBehaviour {

    [SerializeField] private GameObject levelSelector;
    private bool touchedRight;
    private bool touchedLeft;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "TanganOculusRight")
        {
            touchedRight = true;
        }
        else if (collision.gameObject.tag == "TanganOculusLeft")
        {
            touchedLeft = true;
        }
        if (touchedLeft == true && touchedRight == true)
        {
            levelSelector.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "TanganOculusRight")
        {
            touchedRight = false;
        }
        else if (collision.gameObject.tag == "TanganOculusLeft")
        {
            touchedLeft = false;
        }
        if (touchedLeft == false && touchedRight == false)
        {
            levelSelector.SetActive(false);
        }
    }


}
