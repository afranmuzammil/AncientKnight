using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamContoller : MonoBehaviour
{

    public Transform player;

    public Vector3 offset;


    private void Start()
    {
        offset = transform.position - player.transform.position;
    }

    private void Update()
    {
        transform.position = new Vector3(player.position.x + offset.x, /*player.position.y + offset.y,*/0, player.position.z + offset.z);
    }


}

