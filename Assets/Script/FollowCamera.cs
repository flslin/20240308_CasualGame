using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowCamera : MonoBehaviour
{
    public Transform target; // 카메라가 보일 오브젝트 위치
    public Vector3 Offset;   // 카메라 간격좌표

    // 카메라에서 고정 프레임으로 잡는게 편할 수도있음
    void FixedUpdate()
    {
        transform.position = target.position + Offset;
        
    }
}
