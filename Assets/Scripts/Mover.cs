using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{ 
    [SerializeField] float moveSpeed = 12.0f;
    [SerializeField] float jumpForce = 300f;
    [SerializeField] LayerMask groundLayer;
    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Control the yellow block using the WASD keys");
        Debug.Log("Avoid the obstacles and walls");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        var jump = Input .GetButtonDown("Jump");
        transform.Translate(xValue, 0, zValue);        
        if(transform.position.y < 0.35f)
        {
            transform.Translate(0,0.01f,0);
        }

        if(jump)
        {
            if(isGrounded)
            {
            this.gameObject.GetComponent<Rigidbody>().AddForce(transform.up * jumpForce);
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        if((groundLayer.value & (1 << other.transform.gameObject.layer)) > 0)
        {
            isGrounded = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if((groundLayer.value & (1 << other.transform.gameObject.layer)) > 0)
        {
            isGrounded = false;
        }
    }
}
