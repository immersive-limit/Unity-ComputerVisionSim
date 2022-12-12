using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update() {

        // transformを取得
        Transform myTransform = this.transform;

        // 座標を取得
        Vector3 pos = myTransform.position;
        pos.x += 0.01f;    // x座標へ0.01加算  
        myTransform.position = pos;  // 座標を設定

        // 角度を取得
        Vector3 rot = myTransform.eulerAngles;
        rot.x += 0.01f;    // x座標へ0.01加算
        myTransform.eulerAngles = rot;  // 角度を設定
    }
}
