using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory; // 총알 프리팹
    public Transform firePosition; // 발사 위치

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0은 마우스 왼쪽 버튼을 나타냅니다.
        {
            GameObject bullet = Instantiate(bulletFactory);
            bullet.transform.position = firePosition.position; // 발사 위치로 이동
        }
    }
}

