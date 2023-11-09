using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private static PlayerInput instance;
    public static PlayerInput Instance => instance;

    private Vector2 directionInput;
    public Vector2 DirectionalInput => directionInput;

    private void Awake()
    {
        instance = this;
    }
    void Update()
    {
        // Movimiento teclas
        directionInput = new Vector2(Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical"));
    }
}
