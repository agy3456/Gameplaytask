using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFollowPlayer : MonoBehaviour
{
    public Transform player; // 따라갈 플레이어의 Transform
    public float moveSpeed = 5.0f; // 이동 속도

    void Update()
    {
        if (player != null)
        {
            // 플레이어를 향하는 방향 벡터 계산
            Vector3 moveDirection = (player.position - transform.position).normalized;

            // 이동 벡터 계산
            Vector3 moveVector = moveDirection * moveSpeed * Time.deltaTime;

            // 오브젝트를 부드럽게 이동
            transform.Translate(moveVector);
        }
    }
}
