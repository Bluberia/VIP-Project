using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportCamping : MonoBehaviour
{
    public Transform player;

    // Start is called before the first frame update
    public void Teleport()
    {
        Vector3 newPos;
        newPos.x = 24;
        newPos.y = player.position.y;
        newPos.z = 113;
        player.position = newPos;
    }
}
