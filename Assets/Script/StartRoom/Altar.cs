using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Altar : MonoBehaviour {

    [SerializeField] private string button;
    [SerializeField] private GameObject buttonBar;
    [SerializeField] private float buttonBarPercentage;
    [SerializeField] private Room room;
    [SerializeField] private GameObject magicCircle;
    [SerializeField] private GameObject kinectControler;
    private float ratio;
    private bool isTouching;
    private bool touchedRight;
    private bool touchedLeft;

    // Use this for initialization
    void Start () {
        isTouching = false;
        buttonBarPercentage = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (isTouching)
        {
            if (buttonBarPercentage >= 3)
            {
                if (button == "Before")
                {
                    isTouching = false;
                    room.LevelSelect("Before");
                }

                else if (button == "Select")
                {
                    kinectControler = GameObject.Find("KinectController");
                    Destroy(kinectControler);
                    isTouching = false;
                    PlayerPrefs.SetInt("RoomSelected", room.roomNumber);
                    magicCircle.GetComponent<ParticleSystem>().Play();
                    magicCircle.GetComponent<AudioSource>().Play();
                    Invoke("EnterWorld", 3);
                }

                else if (button == "After")
                {
                    isTouching = false;
                    room.LevelSelect("After");
                }

                //Debug.Log("asd");
                return;
            }
            if (button == "Before" && room.isMin == true)
            {
                return;
            }

            if(button == "After" && room.isMax == true)
            {
                return;
            }

            buttonBarPercentage += Time.deltaTime;
            ratio = buttonBarPercentage / 3;
            buttonBar.transform.localScale = new Vector3(ratio, 1, 1);
        }
        else
        {
            buttonBarPercentage = 0;
            buttonBar.transform.localScale = new Vector3(0, 1, 1);
        }
    }

    private void EnterWorld()
    {
        SceneManager.LoadScene("World1");
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "TanganOculusRight")
        {
            if(!touchedLeft)
            {
                touchedRight = true;
                isTouching = true;
            }
        }

        else if (collision.gameObject.tag == "TanganOculusLeft")
        {
            if (!touchedRight)
            {
                touchedLeft = true;
                isTouching = true;
            }
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "TanganOculusRight")
        {
            if (touchedRight)
            {
                touchedRight = false;
                isTouching = false;
            }
            
        }

        else if (collision.gameObject.tag == "TanganOculusLeft")
        {
            if (touchedLeft)
            {
                touchedLeft = false;
                isTouching = false;
            }

        }
    }
}
