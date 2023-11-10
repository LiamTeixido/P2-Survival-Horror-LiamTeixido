using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour, IAttackable
{
    [SerializeField]
    private float speed;
    private Rigidbody rb;

    public float horizontalInput;
    public float verticalInput;

    public int health = 100;

    public void TakeDamage(int damage)
    {
        // Reducir la salud del jugador
        health -= damage;

        // Comprobar si la salud del jugador ha llegado a cero o menos
        if (health <= 0)
        {
            Die();
        }
    }
    

    public void OnAttack(int damage)
    {
        // Implementa el manejo del ataque al jugador aquí
        TakeDamage(damage);
    }

    //Muerte xd
    public void Die()
    {
        Destroy(gameObject);
    }

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