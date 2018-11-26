using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room4Script : MonoBehaviour {

    [SerializeField]
    private GameObject[] wall;
    [SerializeField]
    private GameObject gate, statue, room5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Lamp")
        {
            statue.active = false;
            gate.active = true;
            room5.SetActive(true);
            for (int i = 0; i < 4; i++)
            {
                wall[i].active = false;
                if (PlayerPrefs.GetInt("Level") < 4)
                {
                    PlayerPrefs.SetInt("Level", 4);
                }
            }
        }

    }
}
