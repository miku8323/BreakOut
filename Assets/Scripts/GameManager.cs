using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject[] blocks = new GameObject[36];

    // Start is called before the first frame update
    void Start()
    {
        // block生成
        // GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject sphere_prefab = Resources.Load<GameObject>("Block");
        for(int j = 0; j < 4; j++)
        {
            for (int i = 0; i < 9; i++)
            {
                blocks[j*9+i] = Instantiate(sphere_prefab);
                blocks[j*9+i].transform.position = new Vector3(-6.17f + 0.5f * j, 0.3f, -4.0f + 1.0f * i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 終了判定
        if(DestroyAllBlocks())
        {
            // クリア
            Debug.Log("クリア");
        }
    }

    private void setBlock()
    {

    }

    // 終了判定
    private bool DestroyAllBlocks()
    {
        foreach(GameObject b in blocks)
        {
            if(b != null)
            {
                return false;
            }
        }
        return true;
    }

    public void GameOver()
    {
        Debug.Log("ゲームオーバー");
    }

    // ボタン押したら早送り
}