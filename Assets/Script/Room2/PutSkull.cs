using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutSkull : MonoBehaviour {
    [SerializeField]
    private GameObject[] skulls;
    [SerializeField]
    private GameObject[] kinect;
    private int flag;
    [SerializeField]
    private GameObject door;
    [SerializeField]
    private GameObject magicCircle;
	// Use this for initialization
	void Start () {
        flag = 0;
        //skulls = GameObject.FindGameObjectsWithTag("Skull2");
	}
	
	// Update is called once per frame
	void Update () {
        //magicCircle.GetComponent<ParticleSystem>().Play();
    }

    public void TaruhSkull(int skull)
    {
        skulls[skull].active = true;
        flag++;
        CheckSkull();
    }
    
    private void CheckSkull()
    {
        if (flag == 6)
        {
            door.active = false;
            magicCircle.GetComponent<ParticleSystem>().Play();
            magicCircle.GetComponent<AudioSource>().Play();
            for (int i = 0; i < kinect.Length; i++)
            {
                kinect[i].SetActive(true);
            }
            if (PlayerPrefs.GetInt("Level") < 2)
            {
                PlayerPrefs.SetInt("Level", 2);
                Debug.Log(PlayerPrefs.GetInt("Level"));
            }
        }
    }
}
