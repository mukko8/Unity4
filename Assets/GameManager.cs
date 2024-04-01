using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    int score=0;
    public TextMeshProUGUI scoreText;
    public GameObject msgText;
    //点数を1増やすメソッド
    public void IncreaseScore(){
        score++;
        scoreText.text=score.ToString();
    }
    //ゲーム終了後に動くメソッド
    public void GameEnd(){
        msgText.SetActive(true);
        //timeScaleを0にすると物体が止まる
        Time.timeScale=0f;
    }
}
