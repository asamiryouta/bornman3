using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decision : MonoBehaviour
{
    public bool isdecision = false; //当たった時に変わる用の変数

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag ("Player"))
        {
            isdecision = true;
            Debug.Log("playerHit");
        }

    }
}

