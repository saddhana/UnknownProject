using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour {
    public int roomNumber;
    [SerializeField] private GameObject before, after;
    public bool isMin, isMax;

    // Use this for initialization
    void Start() {
        GetComponent<TextMesh>().text = roomNumber.ToString();
    }

    // Update is called once per frame
    void Update() {
        Debug.Log(PlayerPrefs.GetInt("Level"));
        //PlayerPrefs.SetInt("Level", 5);
        if (roomNumber == 1 && PlayerPrefs.GetInt("Level") == 0)
        {
            Debug.Log("1");
            before.SetActive(false);
            isMin = true;
            after.SetActive(false);
            isMax = true;
        }
        else if (roomNumber == 1)
        {
            Debug.Log("2");
            before.SetActive(false);
            isMin = true;
        }
        else if(roomNumber == PlayerPrefs.GetInt("Level"))
        {
            Debug.Log("3");
            after.SetActive(false);
            isMax = true;
        }
        else
        {
            Debug.Log("4");
            before.SetActive(true);
            after.SetActive(true);
            isMin = false;
            isMax = false;
        }
    }

    public void LevelSelect(string command)
    {
        if(command == "Before")
        {
            roomNumber = roomNumber - 1;
            GetComponent<TextMesh>().text = roomNumber.ToString();
        }

        else if(command == "After")
        {
            roomNumber = roomNumber + 1;
            GetComponent<TextMesh>().text = roomNumber.ToString();
        }
    }
}
