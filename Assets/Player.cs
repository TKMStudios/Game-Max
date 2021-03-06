﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Player", menuName = "Player")]
public class Player : ScriptableObject
{

    public new string name;

    public Sprite playerPicture;

    public float speed;
    public float jumpSpeed;
    public float gravity;
    public int health;

}