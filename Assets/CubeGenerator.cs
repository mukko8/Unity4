using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    public GameObject prefab;
    public GameManager gm;

    //Startでの処理がコルーチンの起動のみの場合はStart自体をコルーチン化できる
    IEnumerator Start()
    {
        //キューブの生成間隔
        float delta = 1.5f;
        //無限ループ
        while(true){
            //Cubeのインスタンス化
            GameObject cube = Instantiate(
                prefab,
                new Vector3(
                    Random.Range(-12f,12f),
                    Random.Range(8f,12f),
                    Random.Range(-3f,3f)
                ),
                Quaternion.identity
            );
            //cubeのCubeControllerにアクセスし、GMを登録する
            cube.GetComponent<CubeController>().GM=gm;
            //delta秒の停止
            yield return new WaitForSeconds(delta);
        
            if(delta > 0.5f){
                //生成間隔を早くしていく
                delta -=0.05f;
            }
        }
    }
}
