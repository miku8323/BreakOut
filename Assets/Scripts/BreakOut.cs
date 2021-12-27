using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakOut : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        // blockの生成
        // GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject sphere_prefab = Resources.Load<GameObject>("Block");
        for(int j = 0; j < 4; j++)
        {
            for (int i = 0; i < 9; i++)
            {
                GameObject sphere = Instantiate(sphere_prefab);
                sphere.transform.position = new Vector3(-6.17f + 0.5f * j, 0.3f, -4.0f + 1.0f * i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 判定
    }

    private void setBlock()
    {

    }

    // スピードアップ（なかなか降りてこないときとかあるでしょ））
    // ボタン操作（リスタート）
}
