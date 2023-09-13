using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBGM : MonoBehaviour
{
    public 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("gege");
        GetComponent<AudioSource>().Play();
    }
}
