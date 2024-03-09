using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcController : MonoBehaviour
{
    // Нужно 3 переменных - Цель - Скорость движения - Физика

    public Transform target;
    public float moveSpeed = 5f;
    private Rigidbody npcRigidbody;
    void Start()
    {
        npcRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (target != null)
        {
            // Получаем направление к нашей цели
            Vector3 direction = (target.position - transform.position).normalized;
            Vector3 moveVelocity = direction * moveSpeed;
            // Применяем движение к Rigidbody

            npcRigidbody.velocity = new Vector3(moveVelocity.x, npcRigidbody.velocity.y, moveVelocity.z);
            transform.LookAt(target);
        }
    }
}
