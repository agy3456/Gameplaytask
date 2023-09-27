using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab; // 총알 프리팹
    public Transform firePoint; // 총알 발사 위치

    public float bulletSpeed = 10f; // 총알 속도

    void Update()
    {
        // 마우스 왼쪽 버튼을 클릭하면 총알 발사
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // 총알을 총구 위치에서 생성
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // 총알에 속도를 적용하여 발사
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = transform.forward * bulletSpeed;
        }
    }
}
