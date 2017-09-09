using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(Cinemachine.CinemachineVirtualCamera))]

public class HitVcamManager : MonoBehaviour {

    private Cinemachine.CinemachineVirtualCamera vcam;      // cinemachineカメラ

    public const int PRIORITY_HIGH = 11;

    public const int PRIORITY_LOW = -1;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // マウスが離されたとき
		if(Input.GetMouseButtonUp(0))
        {
            Debug.Log("Mouse Right Up");
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        SetPriority(PRIORITY_HIGH);
    }

    private void OnTriggerExit(Collider other)
    {
        SetPriority(PRIORITY_LOW);
    }

    /// <summary>
    /// カメラの優先度設定
    /// </summary>
    /// <param name="priority">優先度</param>
    private void SetPriority(int priority)
    {
        if (vcam == null)
        {
            vcam = GetComponent<Cinemachine.CinemachineVirtualCamera>();
        }

        if (vcam)
        {
            vcam.Priority = priority;
        }
    }
}
