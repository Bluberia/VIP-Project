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

    private void OnTriggerEnter(Collider collider)
    {
        switch(collider.transform.name)
        {
            case "CampingTeleport":
                this.TeleportCamping();
                break;
            case "WaterTeleport":
                this.TeleportWater();
                break;
        }
    }

    private void TeleportCamping() {
        player.position = camping.position;
    }

    private void TeleportWater()
    {
        player.position = water.position;
    }
}
