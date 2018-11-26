using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullScript : MonoBehaviour {
    [SerializeField]
    private int skull;
    [SerializeField]
    private PutSkull putSkull;
	// Use this for initialization
	void Start () {
        putSkull = GameObject.FindObjectOfType<PutSkull>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Meja")
        {
            Destroy(gameObject);
            putSkull.TaruhSkull(skull);
        }

    }
}
