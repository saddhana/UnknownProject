using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room3Controller : MonoBehaviour {

    [SerializeField]
    private int direction;
    [SerializeField]
    private Room3StatueController room3StatueController;
    [SerializeField] private GameObject statue;
    [SerializeField] private bool isMoving;
    [SerializeField] private bool right;
    private bool isStop;

	// Use this for initialization
	void Start () {
        isStop = true;
	}

    // Update is called once per frame
    void Update() {
        if (isMoving)
        {
            if(right == true && direction == 3)
            {
                return;
            }

            statue.GetComponent<AudioSource>().Play();
            if (direction == 1)
            {
                room3StatueController.Room3Forward();
            }
            else if (direction == 2)
            {
                room3StatueController.Room3Left();
            }
            else if (direction == 3)
            {
                room3StatueController.Room3Right();
            }
            else
            {
                room3StatueController.Room3Backward();
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "TanganKanan")
        {
            isMoving = true;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (right == true && direction == 3)
        {
            right = false;
        }
        if (collision.gameObject.tag == "TanganKanan")
        {
            isMoving = false;
            room3StatueController.Stop();
            statue.GetComponent<AudioSource>().Stop();
        }

    }
}
