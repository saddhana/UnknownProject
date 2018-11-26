using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MagicRoom6 : MonoBehaviour {

    public bool grimoireOn;
    [SerializeField]
    private GameObject magicCircle;

    // Use this for initialization
    void Start () {
        grimoireOn = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "TanganOculusRight" || collision.gameObject.tag == "TanganOculusLeft")
        {
            if(grimoireOn)
            {
                if (PlayerPrefs.GetInt("Level") < 6)
                {
                    PlayerPrefs.SetInt("Level", 6);
                }
                magicCircle.GetComponent<ParticleSystem>().Play();
                magicCircle.GetComponent<AudioSource>().Play();
                Invoke("GameEnd", 3);
            }
        }
    }

    private void GameEnd()
    {
        SceneManager.LoadScene("StartRoom");
    }

}
