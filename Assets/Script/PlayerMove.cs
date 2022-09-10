using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Vector3 dir;           //�ړ�����
    [SerializeField] private float speed = 5.0f;    //�ړ����x

    // Update is called once per frame
    void Update()
    {
        //// WASD���͂���AXZ����(�����Ȓn��)���ړ��������(dir)�𓾂�
        dir = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            dir.z += 1;

        if (Input.GetKey(KeyCode.A))
            dir.x -= 1;

        if (Input.GetKey(KeyCode.S))
            dir.z -= 1;

        if (Input.GetKey(KeyCode.D))
            dir.x += 1;

        // ���x�x�N�g���̒�����1�b��Speed�����i�ނ悤�ɒ���
        dir = dir.normalized * speed * Time.deltaTime;

        // �����ꂩ�̕����Ɉړ����Ă���ꍇ
        if(dir.magnitude > 0)
        {

            // �v���C���[�̈ʒu(transform.position)�̍X�V
            // �ړ������x�N�g��(dir)�𑫂�
            transform.position += dir;
        }
    }
}
