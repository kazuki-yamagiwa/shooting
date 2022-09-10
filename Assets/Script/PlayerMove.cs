using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Vector3 dir;           //移動方向
    [SerializeField] private float speed = 5.0f;    //移動速度

    // Update is called once per frame
    void Update()
    {
        //// WASD入力から、XZ平面(水平な地面)を移動する方向(dir)を得る
        dir = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            dir.z += 1;

        if (Input.GetKey(KeyCode.A))
            dir.x -= 1;

        if (Input.GetKey(KeyCode.S))
            dir.z -= 1;

        if (Input.GetKey(KeyCode.D))
            dir.x += 1;

        // 速度ベクトルの長さを1秒でSpeedだけ進むように調整
        dir = dir.normalized * speed * Time.deltaTime;

        // いずれかの方向に移動している場合
        if(dir.magnitude > 0)
        {

            // プレイヤーの位置(transform.position)の更新
            // 移動方向ベクトル(dir)を足す
            transform.position += dir;
        }
    }
}
