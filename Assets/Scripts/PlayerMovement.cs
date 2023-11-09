using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Rigidbody rb;

    public float horizontalInput;
    public float verticalInput;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.velocity = new Vector3(
            PlayerInput.Instance.DirectionalInput.x, rb.velocity.y,
            PlayerInput.Instance.DirectionalInput.y) * speed;
    }
}
