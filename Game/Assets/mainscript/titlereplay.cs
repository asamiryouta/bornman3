using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlereplay : MonoBehaviour
{
    [SerializeField]
    [Tooltip("playerPPrefab")]
    public GameObject playerPPrefab;
    public GameObject kumoPPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�ݒ肵��playerpprefab
        GameObject playerObj = GameObject.Find(playerPPrefab.name);
        GameObject kumoObj = GameObject.Find(kumoPPrefab.name);

        if (playerObj == null)
        {
            //playerObg�����݂��Ă��Ȃ��ꍇ
            GameObject newPlayerObj = Instantiate(playerPPrefab);

            //�V�����쐬����gameobject�̖��O�̍Đݒ�
            newPlayerObj.name = playerPPrefab.name;

        }

        if(kumoObj == null)
        {
            //playerObg�����݂��Ă��Ȃ��ꍇ
            GameObject newKumoObj = Instantiate(kumoPPrefab);

            //�V�����쐬����gameObject�̖��O�Đݒ�
            newKumoObj.name = kumoPPrefab.name;
        }

    }
}
