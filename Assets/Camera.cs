using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // z값까지 player의 position 값을 따라가게하니 게임을 시작했을때 player 오브젝트가 카메라에 안잡혀서 z축이 -1만큼 내려가게 설정함
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z - 1);
    }
}
