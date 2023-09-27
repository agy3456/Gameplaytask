using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowRawImageOnObjectRemoval : MonoBehaviour
{
    public RawImage rawImage; // 활성화할 Raw Image 컴포넌트
    public float delayInSeconds = 15.0f; // 딜레이 시간 (초)

    void Start()
    {
        // 게임 시작 후 지정된 시간(15초) 뒤에 ActivateRawImage 메서드를 호출
        Invoke("ActivateRawImage", delayInSeconds);
    }

    void ActivateRawImage()
    {
        // Raw Image를 활성화
        rawImage.gameObject.SetActive(true);
    }
}
