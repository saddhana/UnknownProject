using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSelect : MonoBehaviour {

    [SerializeField]
    private int room;
    [SerializeField]
    private GameObject[] lamp, fire, kinect, skull, skull2, statueRoom3, wallRoom4, chestRoom5, keyRoom5, players;
    [SerializeField]
    private GameObject[] door;
    [SerializeField]
    private GameObject statueRoom4, room5, room6;

    private void Awake()
    {
        room = PlayerPrefs.GetInt("RoomSelected");
        //room = 6;
        room = room - 1;
        PlayerPrefs.SetInt("RoomSelected", 0);
    }

    // Use this for initialization
    void Start () {
        skull = GameObject.FindGameObjectsWithTag("Skull");
        CheckRoom();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void CheckRoom()
    {
        if (room == 1)
        {
            Room1();
        }
        else if (room == 2)
        {
            Room2();
        }
        else if (room == 3)
        {
            Room3();
        }
        else if (room == 4)
        {
            Room4();
        }
        else if (room == 5)
        {
            Room5();
        }
    }

    private void Room1()
    {
        door[0].active = false;
        for (int i = 0; i < 4; i++)
        {
            lamp[i].active = true;
            fire[i].active = true;
            kinect[i].active = false;
        }
    }

    private void Room2()
    {
        if (room == 2)
        {
            Room1();
        }

        door[1].active = false;
        for (int i = 4; i < 8; i++)
        {
            kinect[i].active = true;
        }

        for (int i = 0; i < 6; i++)
        {
            skull[i].active = false;
            skull2[i].active = true;
        }


    }

    private void Room3()
    {
        if (room == 3)
        {
            Room1();
            Room2();
        }

        for (int i = 4; i < 8; i++)
        {
            kinect[i].active = false;
        }

        door[2].active = false;
        statueRoom3[0].active = false;
        statueRoom3[1].active = true;

    }

    private void Room4()
    {
        if(room == 4)
        {
            Room1();
            Room2();
            Room3();
        }
        for (int i = 0; i < 4; i++)
        {
            wallRoom4[i].active = false;
        }
        players[0].GetComponent<Transform>().position = new Vector3(-1.746f, 2.286f, 42.955f);
        //players[0].SetActive(false);
        //players[1].SetActive(true);
        room5.SetActive(true);
        room6.SetActive(true);
        statueRoom4.active = false;
        door[3].active = true;
        
    }

    private void Room5()
    {
        if(room == 5)
        {
            Room1();
            Room2();
            Room3();
            Room4();
        }
        for (int i = 0; i < 2; i++)
        {
            keyRoom5[i].SetActive(false);
        }
        door[4].SetActive(false);
        chestRoom5[0].SetActive(false);
        chestRoom5[1].SetActive(true);
    }
}
