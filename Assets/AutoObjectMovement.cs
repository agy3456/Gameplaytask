using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoObjectMovement : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public float moveDistance = 5.0f;

    private Vector3 initialPosition;
    private Vector3 targetPosition;

    void Start()
    {
        initialPosition = transform.position;
        targetPosition = initialPosition + Vector3.right * moveDistance; // 초기 이동 방향 설정
    }

    void Update()
    {
        // 현재 위치에서 목표 위치로 이동합니다.
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // 목표 위치에 도달하면 반대 방향으로 이동합니다.
        if (transform.position == targetPosition)
        {
            if (targetPosition == initialPosition)
                targetPosition += Vector3.right * moveDistance; // 우측으로 이동
            else
                targetPosition = initialPosition; // 초기 위치로 이동
        }
    }
}
