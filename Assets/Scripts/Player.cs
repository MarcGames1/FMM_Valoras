using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpForce = 5f;

    void Start()
    {

    }

    void Update()
    {
        Movement();
        Jump();
        
    }

    private void Movement()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump")){
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector2(0f, jumpForce), ForceMode.Impulse);
        }   
    }

}
