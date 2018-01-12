using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDisplay : MonoBehaviour
{
    public Player playerStats;

    public Text nameText;
    public Image playerImage;

    public Text speedText;
    public Text healthText;

    void Start()
    {
    }
    private Vector3 moveDirection = Vector3.zero;

    void Update()
    {
        healthText.text = playerStats.health.ToString();
        nameText.text = playerStats.name;
        playerImage.sprite = playerStats.playerPicture;
        speedText.text = playerStats.speed.ToString();

        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= playerStats.speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = playerStats.jumpSpeed;

        }
        moveDirection.y -= playerStats.gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}