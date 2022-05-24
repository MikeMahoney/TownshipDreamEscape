using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    [SerializeField] public GameObject inventory;
    [SerializeField] public GameObject scenarios;
    [SerializeField] public GameObject itemError;

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
        if(
            (SceneManager.GetActiveScene().buildIndex == 1 || SceneManager.GetActiveScene().buildIndex == 6) &&
            PlayerPrefs.HasKey("PosX")
        ) {
            Vector3 position = Vector3.zero;
            position.x = PlayerPrefs.GetFloat("PosX");
            position.y = PlayerPrefs.GetFloat("PosY");
            position.z = PlayerPrefs.GetFloat("PosZ");

            player.position = position;
        }
    }
    void Update()
    {
        UICheck();

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

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

    void UICheck() {
         if (Input.GetKeyDown(KeyCode.Q) && !Input.GetKeyDown(KeyCode.E)) {
            if(inventory.activeSelf){
                PlayerPrefs.SetInt("ObjectiveMode", 0);
                PlayerPrefs.SetString("CurrentObjective", "");
                inventory.SetActive(false);
                itemError.SetActive(false);
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            } else {
                inventory.SetActive(true);
                scenarios.SetActive(false);
                itemError.SetActive(false);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
         }
         if (Input.GetKeyDown(KeyCode.E) && !Input.GetKeyDown(KeyCode.Q)) {
            if(scenarios.activeSelf){
                PlayerPrefs.SetInt("ObjectiveMode", 0);
                PlayerPrefs.SetString("CurrentObjective", "");
                itemError.SetActive(false);
                scenarios.SetActive(false);
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            } else {
                scenarios.SetActive(true);
                inventory.SetActive(false);
                itemError.SetActive(false);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
         }
    }
}
