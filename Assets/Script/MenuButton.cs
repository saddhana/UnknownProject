using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour {

    //[SerializeField] private string button;
    [SerializeField] private GameObject[] buttonBar;
    [SerializeField] private float[] buttonBarPercentage;
    [SerializeField] private float[] ratio;
    [SerializeField] private GameObject kinectControler;
    private bool isTouching;
    private PauseButton pauseButton;

	// Use this for initialization
	void Start () {
        isTouching = false;
        buttonBarPercentage[0] = 0;
        buttonBarPercentage[1] = 0;
        pauseButton = FindObjectOfType<PauseButton>();
	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) )
        {
            if (buttonBarPercentage[0] >= 3)
            {
                pauseButton.Pause();

                //Debug.Log("asd");
                return;
            }
            buttonBarPercentage[0] += Time.deltaTime;
            ratio[0] = buttonBarPercentage[0] / 3;
            buttonBar[0].transform.localScale = new Vector3(ratio[0], 1, 1);
        }
        else
        {
            buttonBarPercentage[0] = 0;
            buttonBar[0].transform.localScale = new Vector3(0, 1, 1);
        }

        if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            if (buttonBarPercentage[1] >= 3)
            {
                kinectControler = GameObject.Find("KinectController");
                Destroy(kinectControler);

                SceneManager.LoadScene("StartRoom");

                //Debug.Log("asd");
                return;
            }
            buttonBarPercentage[1] += Time.deltaTime;
            ratio[1] = buttonBarPercentage[1] / 3;
            buttonBar[1].transform.localScale = new Vector3(ratio[1], 1, 1);
        }
        else
        {
            buttonBarPercentage[1] = 0;
            buttonBar[1].transform.localScale = new Vector3(0, 1, 1);
        }


        /*if (isTouching)
        {
            if(buttonBarPercentage >= 3)
            {
                if (button == "Resume")
                {
                    isTouching = false;
                    pauseButton.Pause();
                }

                else if (button == "MainMenu")
                {
                    isTouching = false;
                    SceneManager.LoadScene("StartRoom");
                }

                else if (button == "Exit")
                {
                    isTouching = false;
                    Application.Quit();
                }

                //Debug.Log("asd");
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
        }*/
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "TanganOculus")
        {
            isTouching = true;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "TanganOculus")
        {
            isTouching = false;
        }

    }

}
