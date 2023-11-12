using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camera_walking : MonoBehaviour
{
    public Transform targetPosition; // ��ǥ ����(Transform)�� Inspector���� ������ �� �ֵ��� ���� ����
    public Transform startingPosition; // ���� ����(Transform) ���� �߰�
    private bool isMoving = false; // �̵� ������ ���θ� �����ϴ� ����

    void Start()
    {
        // ������ �� ī�޶� ��ġ�� ���� �������� �ʱ�ȭ
        transform.position = startingPosition.position;
    }

    void Update()
    {
        // �����̽� �ٸ� ������ ī�޶� �̵� ����
        if (Input.GetKeyUp(KeyCode.Space) && !isMoving)
        {
            MoveCameraToTarget();
        }
    }

    void MoveCameraToTarget()
    {
        // ī�޶� ��ǥ �������� �ε巴�� �̵�
        float smoothSpeed = 0.5f; // ���� ������ ���� (1���� ���� ���)
        isMoving = true; // �̵� ����
        transform.position = Vector3.Lerp(transform.position, targetPosition.position, smoothSpeed * Time.deltaTime);
    }
}