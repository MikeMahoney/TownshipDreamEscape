using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 0.5f;
    public float gravity = -9.81f;
    public float jumpHeight = 1f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public Transform player;

    Vector3 velocity;

    bool isGrounded;

    void Start() {
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        Debug.Log(PlayerPrefs.HasKey("PosX"));
        if(SceneManager.GetActiveScene().buildIndex == 1 && PlayerPrefs.HasKey("PosX")) {
            Vector3 position = Vector3.zero;

            position.x = PlayerPrefs.GetFloat("PosX");
            position.y = PlayerPrefs.GetFloat("PosY");
            position.z = PlayerPrefs.GetFloat("PosZ");

            player.position = position;
        }
    }
    void Update()
    {
        if(Cursor.lockState != CursorLockMode.Locked){
            return;
        }
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0) {
            velocity.y = -4f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        // JUMP LOGIC
        // if (Input.GetButtonDown("Jump") && isGrounded) {
        //     velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        // }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
