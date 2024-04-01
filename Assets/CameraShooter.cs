using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShooter : MonoBehaviour
{
    public GameObject prefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            //引数1つでInstantiate
            GameObject obj=Instantiate(prefab);
            //親要素設定（今回はカメラ）
            obj.transform.parent=transform;
            //親要素からのオフセットは0
            obj.transform.localPosition=Vector3.zero;
            //メインカメラからマウスクリックした地点にrayを飛ばす
            Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
            //rayの方向を長さ1にしてdirに代入
            Vector3 dir=ray.direction.normalized;
            //生成したobjのrigidbodyを取得し、速度をdir方向に与える
            obj.GetComponent<Rigidbody>().velocity=dir*100.0f;
        }
    }
}
