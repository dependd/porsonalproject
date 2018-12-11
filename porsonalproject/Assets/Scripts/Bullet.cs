using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //lateUpdateでまいふれーむ弾丸の位置を取得
        //前回のフレームの弾丸と今のフレームの弾丸の位置を比べ、rayを飛ばす
        //そのrayにオブジェクトが当たっているなら処理
	}


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        GameControlor.Instance.CatchPos(collision.gameObject.tag);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Result") ;//後々変更
    }
}
