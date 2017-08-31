using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour {

    private Transform firsPerson_View;
    private Transform firstPerson_Camera;

    private Vector3 firstPerson_View_Rotation = Vector3.zero;

    public float walkSpeed = 6.75f;
    public float runSpeed = 10.0f;
    public float crouchSpeed = 4.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20f;

    private float speed;

    private bool is_moving, is_Grounded, is_Crouching;

    private float inputX, inputY;
    private float inputX_Set, inputY_Set;
    private float inputModifyFactor;

    private bool limitDiagonalSpeed = true;

    private float antiBumpFactor = 0.75f;

    private CharacterController charController;
    private Vector3 moveDirection = Vector3.zero;


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
