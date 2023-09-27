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
        targetPosition = initialPosition + Vector3.right * moveDistance; // �ʱ� �̵� ���� ����
    }

    void Update()
    {
        // ���� ��ġ���� ��ǥ ��ġ�� �̵��մϴ�.
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // ��ǥ ��ġ�� �����ϸ� �ݴ� �������� �̵��մϴ�.
        if (transform.position == targetPosition)
        {
            if (targetPosition == initialPosition)
                targetPosition += Vector3.right * moveDistance; // �������� �̵�
            else
                targetPosition = initialPosition; // �ʱ� ��ġ�� �̵�
        }
    }
}
