using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room1Script : MonoBehaviour {

    [SerializeField]
    private GameObject[] lamp, fire, kinect;
    [SerializeField]
    private GameObject door;
    [SerializeField]
    private bool[] flag;
    // Use this for initialization
    void Start () {

        for (int i = 0; i < 4; i++)
        {
            kinect[i].active = true;
            lamp[i].active = false;
            fire[i].active = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
        Check();
        if(Input.GetKeyDown(KeyCode.Keypad0))
        {
            Lamp(0);
        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Lamp(1);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            Lamp(2);
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            Lamp(3);
        }
    }

    private void Check()
    {
        if (flag[0] == true && flag[1] == true && flag[2] == true && flag[3] == true)
        {
            Debug.Log("GO!");
            door.active = false;
            kinect[0].active = false;
            kinect[1].active = false;
            kinect[2].active = false;
            kinect[3].active = false;
            if (PlayerPrefs.GetInt("Level") < 1)
            {
                PlayerPrefs.SetInt("Level", 1);
            }
        }
    }

    public void Lamp(int direction)
    {
        //Check();

        if(flag[direction] == true)
        {
            lamp[direction].active = false;
            fire[direction].active = false;
            flag[direction] = false;
        }
        else
        {
            lamp[direction].active = true;
            fire[direction].active = true;
            flag[direction] = true;
        }
    }
}
