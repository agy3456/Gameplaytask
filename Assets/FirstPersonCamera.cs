using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public Transform player; // �÷��̾��� Transform
    public float sensitivity = 2.0f; // ���콺 ����
    private float rotationX = 0;

    void Update()
    {
        if (player != null)
        {
            // ���콺 �Է� ó��
            float mouseX = Input.GetAxis("Mouse X") * sensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

            // ī�޶� ȸ��
            rotationX -= mouseY;
            rotationX = Mathf.Clamp(rotationX, -90, 90); // ���� �ü� ���� ����
            transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            player.Rotate(Vector3.up * mouseX);
        }
    }
}
