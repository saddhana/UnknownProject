using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cekPartikel : MonoBehaviour {
    [SerializeField]private int flag;

	// Use this for initialization
	void Start () {
        flag = 0;
	}
	
	// Update is called once per frame
	void Update () {
        flag++;
        
        if(flag == 60)
        {
            gameObject.GetComponent<ParticleSystem>().Play();
            flag = 0;
        }
	}
}
