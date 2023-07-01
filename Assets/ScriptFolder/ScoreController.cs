using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 



public class ScoreController : MonoBehaviour
{
    //スコアを表示するテキスト（追加）
    private GameObject scoreText;

    //得点（追加）
   public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のscoreTextオブジェクトを取得（追加）
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        Text score_text = scoreText.GetComponent<Text>();
        // テキストの表示を入れ替える
        score_text.text = "Score:" + score;

        
    }
}
