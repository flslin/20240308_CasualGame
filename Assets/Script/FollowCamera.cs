using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowCamera : MonoBehaviour
{
    public Transform target; // ī�޶� ���� ������Ʈ ��ġ
    public Vector3 Offset;   // ī�޶� ������ǥ

    // ī�޶󿡼� ���� ���������� ��°� ���� ��������
    void FixedUpdate()
    {
        transform.position = target.position + Offset;
        
    }
}
