using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camera_walking : MonoBehaviour
{
    public Transform targetPosition; // 목표 지점(Transform)을 Inspector에서 지정할 수 있도록 변수 선언
    public Transform startingPosition; // 시작 지점(Transform) 변수 추가
    private bool isMoving = false; // 이동 중인지 여부를 저장하는 변수

    void Start()
    {
        // 시작할 때 카메라 위치를 시작 지점으로 초기화
        transform.position = startingPosition.position;
    }

    void Update()
    {
        // 스페이스 바를 누르면 카메라 이동 시작
        if (Input.GetKeyUp(KeyCode.Space) && !isMoving)
        {
            MoveCameraToTarget();
        }
    }

    void MoveCameraToTarget()
    {
        // 카메라를 목표 지점까지 부드럽게 이동
        float smoothSpeed = 0.5f; // 낮은 값으로 조절 (1보다 작은 양수)
        isMoving = true; // 이동 시작
        transform.position = Vector3.Lerp(transform.position, targetPosition.position, smoothSpeed * Time.deltaTime);
    }
}