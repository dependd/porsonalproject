using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {

    public float speed; //プレイヤーの動くスピード
    [SerializeField] GameObject camera;

    private Vector3 Player_pos; //プレイヤーのポジション
    private Rigidbody rigd;

    void Start()
    {
        Player_pos = GetComponent<Transform>().position; //最初の時点でのプレイヤーのポジションを取得
        rigd = GetComponent<Rigidbody>(); //プレイヤーのRigidbodyを取得
    }

    void Update()
    {
        Vector3 pos = camera.transform.forward;
        pos.y = 0;
        if (Input.GetKey(KeyCode.W))
        {
            rigd.velocity = pos * speed; //プレイヤーの位置を更新
        }

    }
}
