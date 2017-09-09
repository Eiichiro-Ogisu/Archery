using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowOperator : MonoBehaviour {

    // 矢のスピード
    [SerializeField]
    private float _bowSpeed = 20;

    public ButtonInput _buttonSC;

    // GameDetecter用
    public GameObject _detec;

    // Use this for initialization
    void Start () {
        // GameDetecterを取得
        _detec = GameObject.Find("GameManager");

        // ボタン入力のスクリプトを取得
        _buttonSC = gameObject.GetComponent<ButtonInput>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // 的に当たったなら
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Target")
        {
            // 発射フラグを折る
            _detec.GetComponent<ButtonInput>()._isFire = false;
        }

        // ベクトルと速度の初期化
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }

    public void Fire()
    {
        // 弓の発射
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // xとzにspeedをかける
        GetComponent<Rigidbody>().AddForce(0, 0, z += _bowSpeed);
    }
}
