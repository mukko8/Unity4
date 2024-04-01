using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    void OnBecameInvisible(){ //カメラの表示範囲から出たら消去する
        Destroy(gameObject);
    }
}
