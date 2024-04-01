using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public GameManager GM{get;set;}

    void OnCollisionEnter(Collision other){
        if(other.gameObject.CompareTag("Bullet")){
            GM.IncreaseScore();
            Destroy(gameObject,0.1f);
        }
        if(other.gameObject.CompareTag("Floor")){
            GM.GameEnd();
        }
    }
}
