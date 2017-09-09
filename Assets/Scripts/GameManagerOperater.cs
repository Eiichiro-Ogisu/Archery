using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerOperater : MonoBehaviour {

    // ボタン入力スクリプト格納用
    public ButtonInput _buttonInput;

    // 矢
    private GameObject _bow;

	// Use this for initialization
	void Start () {
        // ボタンを取得
        _buttonInput = gameObject.GetComponent<ButtonInput>();

        // 矢を見つけて代入
        _bow = GameObject.Find("Bow");

        // nullチェック
        if (_bow == null)
        {
            Debug.Log("null");
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
		if (_buttonInput.GetBowState())
        {
            Debug.Log("Fire");
            // 発射
            _bow.GetComponent<BowOperator>().Fire();
        }
	}
}
