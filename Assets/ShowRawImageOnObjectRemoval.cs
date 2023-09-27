using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowRawImageOnObjectRemoval : MonoBehaviour
{
    public RawImage rawImage; // Ȱ��ȭ�� Raw Image ������Ʈ
    public float delayInSeconds = 15.0f; // ������ �ð� (��)

    void Start()
    {
        // ���� ���� �� ������ �ð�(15��) �ڿ� ActivateRawImage �޼��带 ȣ��
        Invoke("ActivateRawImage", delayInSeconds);
    }

    void ActivateRawImage()
    {
        // Raw Image�� Ȱ��ȭ
        rawImage.gameObject.SetActive(true);
    }
}
