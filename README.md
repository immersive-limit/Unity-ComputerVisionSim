# Unity-ComputerVisionSim move

![](docs\img_0.0200_4.2200_-13.7100_0.0200_0.0000_0.0000_id.png)


# Index

- [Introduction](#introduction)
- [Updates!!](#updates)
- [Coming soon](#coming-soon)
- [Quick Start](#quick-start)
- [Detail](#detail)
  - [カメラを動かす](#カメラを動かす)
  - [リアルタイム保存](#リアルタイム保存)
- [Reference site](#reference-site)

## Introduction

[Unity-ComputerVisionSim](https://www.immersivelimit.com/tutorials/unity-image-segmentation)にカメラを動かす機能を付与したものです．


## Updates!!
* 【2022/12/12】 ベースのプログラムをクローン
* 【2021/12/14】 カメラが動く機能
* 【2021/12/16】 リアルタイム保存機能

## Coming soon
- [ ] 特になし

## Quick Start

Companion tutorials for this repo:
- [Unity Depth Camera Simulation](http://www.immersivelimit.com/tutorials/unity-depth-camera-simulation)  
- [Unity Image Segmentation](http://www.immersivelimit.com/tutorials/unity-image-segmentation)


## Detail

### カメラを動かす

`Unity\Assets\Scripts\MoveCharacter.cs`でカメラを動かします．

```c#
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

```


### リアルタイム保存

`Unity\Assets\ImageSynthesis\Scripts\ImageSynthesis.cs`でキャプチャー画像を保存します．


```c#

    ... 

    void Update() {

        
        // get camera transform
        Transform myTransform = this.transform;
        
        // save image name
        filename_full = "img" + 
                        "_" + myTransform.position.x.ToString("F4") + "_" + myTransform.position.y.ToString("F4") + "_" + myTransform.position.z.ToString("F4") + 
                        "_" + myTransform.eulerAngles.x.ToString("F4") + "_" + myTransform.eulerAngles.y.ToString("F4") + "_" + myTransform.eulerAngles.z.ToString("F4") + 
                        ".png";
        Debug.Log("filename_full : " + filename_full );
        Save(filename_full, width, height, filepath + "/" + exp_name);

    }

    ... 

```

## Reference site

- [Unity-ComputerVisionSim](https://www.immersivelimit.com/tutorials/unity-image-segmentation)