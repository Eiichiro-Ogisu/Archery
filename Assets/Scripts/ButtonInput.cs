using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonInput : MonoBehaviour {

    // SetVcamカメラ
    private GameObject _setVcam;

    // 構えているか
    private bool _isSetUp;

    // 発射フラグ
    public bool _isFire;

	// Use this for initialization
	void Start () {
        _setVcam = GameObject.Find("SetVcam");

        if(_setVcam == null)
        {
            Debug.Log("null");
        } 

        _isSetUp = false;

        _isFire = false;
	}
	
	// Update is called once per frame
	void Update () {

        //if (_isSetUp)
        //{
        //    // カメラの優先度を変更
        //    Debug.Log("Press");
        //}
    }

    // Setボタンが離されたら
    public void SetButtonUp()
    {
        _isSetUp = false;

        _isFire = true;

        _setVcam.GetComponent<Cinemachine.CinemachineVirtualCamera>().Priority = -1;
    }

    // Setボタンが押されたら
    public void SetButtonDown()
    {
        _isSetUp = true;

        _setVcam.GetComponent<Cinemachine.CinemachineVirtualCamera>().Priority = 20;

        Cursor.lockState = CursorLockMode.Locked;

        Cursor.lockState = CursorLockMode.None;
    }

    public bool GetBowState()
    {
        return _isFire;
    }
}
