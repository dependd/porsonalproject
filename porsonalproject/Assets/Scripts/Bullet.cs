using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour {

    Vector3 fastPos;
    Vector3 basePos;

	// Use this for initialization
	void Start () {
        fastPos = transform.position;
	}
	
	// Update is called once per frame
	//void Update () {
        //lateUpdateでまいふれーむ弾丸の位置を取得
        //前回のフレームの弾丸と今のフレームの弾丸の位置を比べ、rayを飛ばす
        //そのrayにオブジェクトが当たっているなら処理
	//}

    private void Update()
    {
        fastPos = transform.position;

        //rayの作成
        Vector3 pos = transform.forward;
        Ray ray = new Ray(fastPos,pos);
        //rayが当たったオブジェクトの情報を入れる箱
        RaycastHit hit;
        //rayの飛ばせる距離
        int distance = 1;
        //rayの可視化
        Debug.DrawLine(ray.origin, ray.origin + ray.direction * distance,Color.red);
        //もしrayがオブジェクトに衝突したら
        if (Physics.Raycast(ray, out hit, distance))//, LayerMask.NameToLayer("Default")))
        {
            //あたったオブジェクトによって処理
            Debug.Log(hit.collider.gameObject.tag);
            Debug.Log(hit.collider.gameObject.name);
            GameControlor.Instance.CatchPos(hit.collider.gameObject.tag);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("Result");//後々変更
        } else {

        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        /*Debug.Log(collision.gameObject.tag);
        GameControlor.Instance.CatchPos(collision.gameObject.tag);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Result") ;//後々変更*/
    }

    IEnumerator WaitChangeScene(Ray ray,RaycastHit hit,int dictance)
    {
        yield return new WaitForSeconds(3);
        //あたったオブジェクトによって処理
        Debug.Log(hit.collider.gameObject.tag);
        Debug.Log(hit.collider.gameObject.name);
        GameControlor.Instance.CatchPos(hit.collider.gameObject.tag);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Result");//後々変更
    }
}
