using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlePlayerDestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //当たった相手を消す
            Destroy(collision.gameObject);
        }
    }
}
