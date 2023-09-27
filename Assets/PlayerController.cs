using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab; // 총알 Prefab
    public Transform firePoint; // 총알 발사 위치

    void Update()
    {
        // 마우스 클릭으로 총알 발사
        if (Input.GetButtonDown("Fire1")) // Fire1은 기본적으로 마우스 왼쪽 버튼을 나타냅니다.
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // 총알을 발사 위치에서 생성
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // 총알을 움직이게 하거나 추가적인 로직을 여기에 추가할 수 있습니다.
    }
}
