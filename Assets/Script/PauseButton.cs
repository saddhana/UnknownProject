using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour {
    private OVRPlayerController oVRPlayerController;
    [SerializeField] private GameObject pauseMenu;
    private bool isPaused;
    
	// Use this for initialization
	void Start () {
        oVRPlayerController = gameObject.GetComponent<OVRPlayerController>();
        isPaused = false;
	}

    // Update is called once per frame
    void Update()
    {
        if(isPaused)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.P) || OVRInput.GetDown(OVRInput.Button.Start))
        {
            Pause();
        }
    }

    public void Pause()
    {
        if(!isPaused)
        {
            isPaused = true;
            pauseMenu.SetActive(true);
            oVRPlayerController.SetHaltUpdateMovement(true);
        }

        else
        {
            isPaused = false;
            pauseMenu.SetActive(false);
            oVRPlayerController.SetHaltUpdateMovement(false);
        }
    }

}
