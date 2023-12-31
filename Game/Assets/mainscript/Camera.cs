using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class Camera : MonoBehaviour
{
    GameObject playerObj;
    charController player;
    Transform PlayerTransform;
    void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");
        player = playerObj.GetComponent<charController>();
        PlayerTransform = playerObj.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //上下追尾
        transform.position = new Vector3(PlayerTransform.position.x,        //playerのx方向の座標
                                         PlayerTransform.position.y + 1.25f,//playerのy方向の座標
                                         transform.position.z);             //playerのz方向の座標
    }
}
