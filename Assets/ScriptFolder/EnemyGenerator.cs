using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField]
    [Tooltip("生成するGameObject1")]
    private GameObject slimePrefab;

    [SerializeField]
    [Tooltip("生成するGameObject2")]
    private GameObject turtlePrefab;


    // 経過時間
    private float time;


    // Update is called once per frame
    void Update()
    {
        // 前フレームからの時間を加算していく
        time = time + Time.deltaTime;

        // 約1秒置きにランダムに生成されるようにする。
        if (time > 3.0f)
        {
            int enemyNumber = Random.Range(1, 100);
            int areaNumber = Random.Range(1, 4);
            if (1 <= enemyNumber && enemyNumber <= 85)
            {
                if (areaNumber == 1)
                {


                    // rangeAとrangeBのx座標の範囲内でランダムな数値を作成
                    float x = Random.Range(10, 30);

                    // rangeAとrangeBのz座標の範囲内でランダムな数値を作成
                    float z = Random.Range(10, 30);


                    // GameObjectを上記で決まったランダムな場所に生成
                    Instantiate(slimePrefab, new Vector3(x, 7, z), slimePrefab.transform.rotation);
                }
                else if (areaNumber == 2)
                {
                    // rangeAとrangeBのx座標の範囲内でランダムな数値を作成
                    float x = Random.Range(-10, -30);

                    // rangeAとrangeBのz座標の範囲内でランダムな数値を作成
                    float z = Random.Range(10, 30);


                    // GameObjectを上記で決まったランダムな場所に生成
                    Instantiate(slimePrefab, new Vector3(x, 7, z), slimePrefab.transform.rotation);
                }
                else if (areaNumber == 3)
                {
                    // rangeAとrangeBのx座標の範囲内でランダムな数値を作成
                    float x = Random.Range(10, 30);

                    // rangeAとrangeBのz座標の範囲内でランダムな数値を作成
                    float z = Random.Range(-10, -30);


                    // GameObjectを上記で決まったランダムな場所に生成
                    Instantiate(slimePrefab, new Vector3(x, 7, z), slimePrefab.transform.rotation);
                }
                else
                {
                    // rangeAとrangeBのx座標の範囲内でランダムな数値を作成
                    float x = Random.Range(-10, -30);

                    // rangeAとrangeBのz座標の範囲内でランダムな数値を作成
                    float z = Random.Range(-10, -30);


                    // GameObjectを上記で決まったランダムな場所に生成
                    Instantiate(slimePrefab, new Vector3(x, 7, z), slimePrefab.transform.rotation);
                }
            }
            else
            {
                if (areaNumber == 1)
                {


                    // rangeAとrangeBのx座標の範囲内でランダムな数値を作成
                    float x = Random.Range(10, 30);

                    // rangeAとrangeBのz座標の範囲内でランダムな数値を作成
                    float z = Random.Range(10, 30);


                    // GameObjectを上記で決まったランダムな場所に生成
                    Instantiate(turtlePrefab, new Vector3(x, 7, z), turtlePrefab.transform.rotation);
                }
                else if (areaNumber == 2)
                {
                    // rangeAとrangeBのx座標の範囲内でランダムな数値を作成
                    float x = Random.Range(-10, -30);

                    // rangeAとrangeBのz座標の範囲内でランダムな数値を作成
                    float z = Random.Range(10, 30);


                    // GameObjectを上記で決まったランダムな場所に生成
                    Instantiate(turtlePrefab, new Vector3(x, 7, z), turtlePrefab.transform.rotation);
                }
                else if (areaNumber == 3)
                {
                    // rangeAとrangeBのx座標の範囲内でランダムな数値を作成
                    float x = Random.Range(10, 30);

                    // rangeAとrangeBのz座標の範囲内でランダムな数値を作成
                    float z = Random.Range(-10, -30);


                    // GameObjectを上記で決まったランダムな場所に生成
                    Instantiate(turtlePrefab, new Vector3(x, 7, z), turtlePrefab.transform.rotation);
                }
                else
                {
                    // rangeAとrangeBのx座標の範囲内でランダムな数値を作成
                    float x = Random.Range(-10, -30);

                    // rangeAとrangeBのz座標の範囲内でランダムな数値を作成
                    float z = Random.Range(-10, -30);


                    // GameObjectを上記で決まったランダムな場所に生成
                    Instantiate(turtlePrefab, new Vector3(x, 7, z), turtlePrefab.transform.rotation);
                }
            }
            // 経過時間リセット
            time = 0f;
        }
    }
}
