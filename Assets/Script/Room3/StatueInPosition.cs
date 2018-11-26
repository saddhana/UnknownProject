using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueInPosition : MonoBehaviour {

    [SerializeField]
    private GameObject statue, kinect, door, particle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Statue")
        {
            collision.gameObject.active = false;
            statue.active = true;
            kinect.active = false;
            door.active = false;
            particle.GetComponent<ParticleSystem>().Play();
            if (PlayerPrefs.GetInt("Level") < 3)
            {
                PlayerPrefs.SetInt("Level", 3);
            }
            Invoke("StopEmitter", 3);
        }

    }

    private void StopEmitter()
    {
        particle.GetComponent<ParticleSystem>().Stop();
    }
}
