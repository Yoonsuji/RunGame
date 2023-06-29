using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveVector;
    private float speed = 5.0f;
    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Run", true);
        moveVector = Vector3.zero;
        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
        moveVector.z = speed;
        controller.Move(moveVector * Time.deltaTime);


    }
}
