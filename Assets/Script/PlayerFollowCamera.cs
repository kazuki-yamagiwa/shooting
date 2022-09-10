using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowCamera : MonoBehaviour
{
    [SerializeField] private Transform player;           //�����Ώ�
    [SerializeField] private float distance = 15.0f;    //�����ΏۂƂ̋���
    [SerializeField] private Quaternion vRotation;      //�J�����̐�����]
    [SerializeField] public Quaternion hRotation;      //�J�����̐�����]
    void Start()
    {
        //��]�̏�����
        vRotation = Quaternion.Euler(20, 0, 0);         // ������](X�������Ƃ����])�́A20�x�����낷��]
        hRotation = Quaternion.identity;                // ������](Y�������Ƃ����])�́A����]
        transform.rotation = hRotation * vRotation;            // �ŏI�I�ȃJ�����̉�]�́A������]���Ă��琅����]���鍇����]

        //�ʒu�̏�����
        // player�ʒu���狗��distance������O�Ɉ������ʒu��ݒ�
        transform.position = player.position - transform.rotation * Vector3.forward * distance;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        // �J�����̈ʒu(transform.position)�̍X�V
        // player�ʒu���狗��distance������O�Ɉ������ʒu��ݒ�
        transform.position = player.position - transform.rotation * Vector3.forward * distance;
    }
}
