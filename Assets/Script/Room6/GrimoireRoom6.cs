using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrimoireRoom6 : MonoBehaviour {

    [SerializeField] private MagicRoom6 magicRoom6;
    [SerializeField] private GameObject magicCircle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "TanganOculusRight" || collision.gameObject.tag == "TanganOculusLeft")
        {
            if (magicRoom6.grimoireOn == false)
            {
                magicRoom6.grimoireOn = true;
                magicCircle.GetComponent<ParticleSystem>().Play();
                magicCircle.GetComponent<AudioSource>().Play();
            }
        }

    }

}
