using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy12 : MonoBehaviour
{
    public float speed = 0.5f; //�G�l�~�[�̃X�s�[�h
    int counter = 50; //if�����s�p


    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 position = transform.position; //enemy�̏ꏊ
        decision decision;
        GameObject obj = GameObject.Find("decision");
        decision = obj.GetComponent<decision>();


        if (decision.isdecision)
        {
            position.x -= speed;
        }

        transform.position = position;
    }
}