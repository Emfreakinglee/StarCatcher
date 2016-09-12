using UnityEngine;
using System.Collections;

public class MoveCharecter : MonoBehaviour {
    private CharacterController myCC;
    private Vector3 tempPos;
    public float speed = 10;
    public float gravity = -5;
    public float jumpSpeed = 1;
    public int jumpCount = 0;
    public int jumpCountMax = 2;
    // Use this for initialization
	void Start () {

        myCC = GetComponent<CharacterController>();
	
	}
	
	// Update is called once per frame
	void Update () {
	    //Waiting for input and comparing jumpcount
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax-1)
        {
            //incrememnting the jumpcount by 1
            jumpCount++;
            //adding the jumpSpeed var to the tempPos var
            tempPos.y = jumpSpeed;
        }
        //test if the character controller is grounded
        if(myCC.isGrounded)
        {
            jumpCount = 0;
        }
        //adding the gravity var to the y position of the tempPosition var
        tempPos.y = gravity;
        //adding the speed var to the tempPos var x value with the right and left arrow keys
        tempPos.x = speed * Input.GetAxis("Horizontal");
        //Moves the character controller at an even pace (delatime)
        myCC.Move(tempPos * Time.deltaTime);
        
	}
}
