using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterRoom5 : MonoBehaviour {
    [SerializeField] private GameObject roomBefore, roomAfter;
    [SerializeField] private GameObject[] wall;
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
            roomBefore.SetActive(false);
            roomAfter.SetActive(true);
            for (int i = 0; i < 4; i++)
            {
                wall[i].SetActive(true);
            }
        }

    }
}
