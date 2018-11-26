using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureKey : MonoBehaviour {

    
    [SerializeField] private string treasure;
    [SerializeField] private GameObject locked, opened, prize, particle;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /*private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == treasure)
        {
            Destroy(gameObject);
            locked.SetActive(false);
            opened.SetActive(true);
            prize.SetActive(true);
            particle.GetComponent<ParticleSystem>().Play();
            particle.GetComponent<AudioSource>().Play();
        }

    }*/

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == treasure)
        {
            Destroy(gameObject);
            locked.SetActive(false);
            opened.SetActive(true);
            prize.SetActive(true);
            particle.GetComponent<ParticleSystem>().Play();
            particle.GetComponent<AudioSource>().Play();
        }

    }
}
