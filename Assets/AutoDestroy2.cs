using UnityEngine;

public class AutoDestroy2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 10초 뒤에 자동으로 제거하도록 함수를 호출합니다.
        Invoke("DestroyGameObject", 20f);
    }

    // 함수를 호출하여 GameObject를 제거합니다.
    void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
