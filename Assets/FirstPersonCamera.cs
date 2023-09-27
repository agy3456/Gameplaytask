using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public Transform player; // 플레이어의 Transform
    public float sensitivity = 2.0f; // 마우스 감도
    private float rotationX = 0;

    void Update()
    {
        if (player != null)
        {
            // 마우스 입력 처리
            float mouseX = Input.GetAxis("Mouse X") * sensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

            // 카메라 회전
            rotationX -= mouseY;
            rotationX = Mathf.Clamp(rotationX, -90, 90); // 상하 시선 각도 제한
            transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            player.Rotate(Vector3.up * mouseX);
        }
    }
}
