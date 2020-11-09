using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportWater : MonoBehaviour
{
    public Transform player;

    // Start is called before the first frame update
    public void Teleport()
    {
        Vector3 newPos;
        newPos.x = 102;
        newPos.y = player.position.y;
        newPos.z = 71;
        player.position = newPos;
    }
}
