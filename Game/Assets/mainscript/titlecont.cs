using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlecont : MonoBehaviour
{
    Vector3 Move;
    public float speed;
    bool isMoveFlag;
    bool resFlag;

    // Start is called before the first frame update
    void Start()
    {
        Move = transform.position;
        speed = 0.1f;
        isMoveFlag = true;
        resFlag = true;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Flag"))
        {
            Destroy(this.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (isMoveFlag)
        {
            Move.x -= speed;
        }

        transform.position = Move;
    
    }

}
