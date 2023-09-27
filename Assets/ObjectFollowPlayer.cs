using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFollowPlayer : MonoBehaviour
{
    public Transform player; // ���� �÷��̾��� Transform
    public float moveSpeed = 5.0f; // �̵� �ӵ�

    void Update()
    {
        if (player != null)
        {
            // �÷��̾ ���ϴ� ���� ���� ���
            Vector3 moveDirection = (player.position - transform.position).normalized;

            // �̵� ���� ���
            Vector3 moveVector = moveDirection * moveSpeed * Time.deltaTime;

            // ������Ʈ�� �ε巴�� �̵�
            transform.Translate(moveVector);
        }
    }
}
