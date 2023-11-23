using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]

    public float horizontalInput;
    public float verticalInput;

    private CharacterController player;
    public float movementSpeed = 5.0f;

    void Awake()
    {
        player = GetComponent<CharacterController>();
    }

    void Update()
    {
        float forwardMovement = Input.GetAxis("Vertical") * movementSpeed;
        float strafeMovement = Input.GetAxis("Horizontal") * movementSpeed;

        Vector3 speed = new Vector3(strafeMovement, 0, forwardMovement);
        speed = transform.rotation * speed;
        player.SimpleMove(speed);
    }
}
