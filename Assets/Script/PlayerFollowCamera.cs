using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowCamera : MonoBehaviour
{
    [SerializeField] private Transform player;           //注視対象
    [SerializeField] private float distance = 15.0f;    //注視対象との距離
    [SerializeField] private Quaternion vRotation;      //カメラの垂直回転
    [SerializeField] public Quaternion hRotation;      //カメラの水平回転
    void Start()
    {
        //回転の初期化
        vRotation = Quaternion.Euler(20, 0, 0);         // 垂直回転(X軸を軸とする回転)は、20度見下ろす回転
        hRotation = Quaternion.identity;                // 水平回転(Y軸を軸とする回転)は、無回転
        transform.rotation = hRotation * vRotation;            // 最終的なカメラの回転は、垂直回転してから水平回転する合成回転

        //位置の初期化
        // player位置から距離distanceだけ手前に引いた位置を設定
        transform.position = player.position - transform.rotation * Vector3.forward * distance;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        // カメラの位置(transform.position)の更新
        // player位置から距離distanceだけ手前に引いた位置を設定
        transform.position = player.position - transform.rotation * Vector3.forward * distance;
    }
}
