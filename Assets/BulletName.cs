using UnityEngine;

public class BulletName : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        // 만약 충돌한 오브젝트의 태그가 "Ground"이면 총알 삭제
        if (other.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
