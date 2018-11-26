using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room1Button : MonoBehaviour {

    [SerializeField]
    private Room1Script room1Script;
    [SerializeField]
    private int direction;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "TanganKanan")
        {
            room1Script.Lamp(direction);
        }

    }

}
