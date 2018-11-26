using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    [SerializeField] private string doorName;
    [SerializeField] public GameObject particle; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == doorName)
        {
            if(doorName == "Room5Door")
            {
                if (PlayerPrefs.GetInt("Level") < 5)
                {
                    PlayerPrefs.SetInt("Level", 5);
                }
            }
            Destroy(gameObject);
            Destroy(col.gameObject);
            particle.GetComponent<ParticleSystem>().Play();
            particle.GetComponent<AudioSource>().Play();
        }

    }
}
