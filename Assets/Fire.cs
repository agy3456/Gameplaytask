using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f; // 총알 속도

    void Update()
    {
        // 총알을 앞으로 이동
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        // 총알이 화면 밖으로 나가면 제거
        if (GetComponent<Renderer>() != null && !GetComponent<Renderer>().isVisible)
        {
            Destroy(gameObject);
        }
    }
}
