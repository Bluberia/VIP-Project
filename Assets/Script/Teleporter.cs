using System.Runtime.CompilerServices;
using System.Security;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{

    public Transform camping;
    public Transform water;
    public Transform player;

    public void TeleportCamping() {
        player.position = camping.position;
    }

    public void TeleportWater() {
        player.position = water.position;
    }
}
