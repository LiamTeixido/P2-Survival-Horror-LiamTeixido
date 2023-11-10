using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    private Transform player;
    private int damageToPlayer = 50;
    private float attackRange = 1.0f;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (player != null)
        {
            Vector3 direction = (player.position - transform.position).normalized;

            transform.Translate(direction * moveSpeed * Time.deltaTime);

            float distance = Vector3.Distance(transform.position, player.position);

            if (distance < attackRange)
            {
                IAttackable attackable = player.GetComponent<IAttackable>();
                if (attackable != null)
                {
                    attackable.OnAttack(damageToPlayer);
                }
            }
        }
    }
}
