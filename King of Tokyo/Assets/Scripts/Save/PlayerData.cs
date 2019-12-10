using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int vp;
    public int health;
    public float[] position;
    public int pid;

    public PlayerData(Player player)
    {
      vp = player.victoryPoints;
        health = player.health;
        position = new float[2];
        pid = player.playerID;
        //position[0] = player.transform.x;
        //position[1] = player.transform.y;

    }
}

