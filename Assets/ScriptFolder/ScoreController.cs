using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 



public class ScoreController : MonoBehaviour
{
    //�X�R�A��\������e�L�X�g�i�ǉ��j
    private GameObject scoreText;

    //���_�i�ǉ��j
   public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //�V�[������scoreText�I�u�W�F�N�g���擾�i�ǉ��j
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        // �I�u�W�F�N�g����Text�R���|�[�l���g���擾
        Text score_text = scoreText.GetComponent<Text>();
        // �e�L�X�g�̕\�������ւ���
        score_text.text = "Score:" + score;

        
    }
}
