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
        //設定したplayerpprefab
        GameObject playerObj = GameObject.Find(playerPPrefab.name);
        GameObject kumoObj = GameObject.Find(kumoPPrefab.name);

        if (playerObj == null)
        {
            //playerObgが存在していない場合
            GameObject newPlayerObj = Instantiate(playerPPrefab);

            //新しく作成したgameobjectの名前の再設定
            newPlayerObj.name = playerPPrefab.name;

        }

        if(kumoObj == null)
        {
            //playerObgが存在していない場合
            GameObject newKumoObj = Instantiate(kumoPPrefab);

            //新しく作成したgameObjectの名前再設定
            newKumoObj.name = kumoPPrefab.name;
        }

    }
}
