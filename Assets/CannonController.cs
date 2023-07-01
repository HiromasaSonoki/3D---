using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;  //（追加）

public class CannonController : MonoBehaviour
{
    //プレハブ
    public GameObject bulletPrefab;

    //ゲーム終了の判定（追加）
    public bool isEnd = false;
    //大砲に当たり判定を入れる
    private Rigidbody myRigidbody;
    //ゲーム終了時に表示するテキスト（追加）
    private GameObject stateText;
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbodyコンポーネントを取得（追加）
        this.myRigidbody = GetComponent<Rigidbody>();

        //シーン中のstateTextオブジェクトを取得（追加）
        this.stateText = GameObject.Find("GameResultText");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(0.0f, -30.0f * Time.deltaTime, 0.0f, Space.World);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(0.0f, 30.0f * Time.deltaTime, 0.0f, Space.World);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, this.transform.position + new Vector3(0.0f, 1.3f, 0.0f), this.transform.rotation);
        }

        if (this.isEnd == true)
        {
            // クリックされたらシーンをロードする（追加）
            if (Input.GetMouseButtonDown(0))
            {
                //SampleSceneを読み込む（追加）
                SceneManager.LoadScene("SampleScene");
                Time.timeScale = 1f;
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Time.timeScale = 0f;
            this.isEnd = true;
            //stateTextにGAME OVERを表示（追加）
            this.stateText.GetComponent<Text>().text = "GAME OVER";
        }
    }
}