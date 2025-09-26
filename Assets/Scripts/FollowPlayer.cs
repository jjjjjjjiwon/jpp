using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] GameObject player;
    Vector3 offeset = new Vector3(0, 6, -13);
    void Start()
    {

    }

    // 카메라 이동은 LateUpdate에서 해야한다
    void LateUpdate()
    {
        transform.position= player.transform.position + offeset;
    }
}
