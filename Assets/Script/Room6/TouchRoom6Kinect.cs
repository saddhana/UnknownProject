using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRoom6Kinect : MonoBehaviour {

    [SerializeField] private GameObject[] prizon;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Tangan")
        {
            //prizon.GetComponent<MeshRenderer>().enabled = false;
            for (int i = 0; i < prizon.Length; i++)
            {
                prizon[i].SetActive(false);
            }
        }

    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Tangan")
        {
            //prizon.GetComponent<MeshRenderer>().enabled = true;
            for (int i = 0; i < prizon.Length; i++)
            {
                prizon[i].SetActive(true); 
            }
        }

    }

}
