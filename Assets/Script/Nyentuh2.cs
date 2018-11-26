using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nyentuh2 : MonoBehaviour {

    public Material[] material1;
    public int flag;
    Renderer rend;

    // Use this for initialization
    void Start()
    {
        flag = 0;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material1[0];
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Tangan")
        {
            if(flag == 0)
            {
                rend.sharedMaterial = material1[1];
                flag++;
            }
            else if (flag == 1)
            {
                rend.sharedMaterial = material1[2];
                flag++;
            }
            else if (flag == 2)
            {
                rend.sharedMaterial = material1[0];
                flag = 0;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
