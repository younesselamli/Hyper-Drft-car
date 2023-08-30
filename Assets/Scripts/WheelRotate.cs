using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotate : MonoBehaviour
{
    // ������ ������� ��� ������ ������ (y)
    public float sensitivity = 1.0f;

    void Update()
    {
        // ���� ��� ������� �� ������ ������ ������ ������
        float input = SimpleInput.GetAxis("Horizontal");

        // ��� ������� ��������� �������ɡ �� ����� ���� �������
        float rotationAmount = input * sensitivity;

        // ��� �������� ��� ���� y ������
        transform.Rotate(0, rotationAmount, 0);
    }
}
