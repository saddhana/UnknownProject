using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room3StatueController : MonoBehaviour {

    [SerializeField]
    private float moveSpeed;
    private CharacterController controller;
    [SerializeField]
    private float gravityScale;

    private Vector3 moveDirection;

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        //moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, 0f, Input.GetAxis("Vertical") * moveSpeed);
        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale);
        
        //controller.Move(moveDirection * Time.deltaTime);
	}


    public void Room3Forward()
    {
        Debug.Log("depan");
        //moveDirection = new Vector3(0f, 0f, -moveSpeed);

        GetComponent<Rigidbody>().velocity = transform.forward;
        //moveDirection = new Vector3(-moveSpeed, 0f, 0f);
        //controller.Move(moveDirection * Time.deltaTime);
    }

    public void Room3Backward()
    {
        Debug.Log("belakang");
        //moveDirection = new Vector3(0f, 0f, moveSpeed);
        GetComponent<Rigidbody>().velocity = -transform.forward;
        //controller.Move(moveDirection * Time.deltaTime);
    }

    public void Room3Left()
    {
        Debug.Log("kiri");
        GetComponent<Rigidbody>().velocity = -transform.right;
        //moveDirection = new Vector3(moveSpeed, 0f, 0f);
        //controller.Move(moveDirection * Time.deltaTime);
    }

    public void Room3Right()
    {
        Debug.Log("kanan");
        GetComponent<Rigidbody>().velocity = transform.right;
        //moveDirection = new Vector3(-moveSpeed, 0f, 0f);
        //moveDirection = new Vector3(0f, 0f, -moveSpeed);
        //controller.Move(moveDirection * Time.deltaTime);
    }

    public void Stop()
    {
        Debug.Log("stop");
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        //controller.Move(moveDirection * Time.deltaTime);
    }
}
