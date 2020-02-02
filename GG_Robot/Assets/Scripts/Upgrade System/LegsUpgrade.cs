﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegsUpgrade : UpgradeItem
{
    public override void ApplyAlterations(GameObject player)
    {
        Debug.Log("beep boop you have legs now");
        Movement.Instance.CanDoubleJump = true;
        // player.movementSpeed = 2;

    }
    public override void RevertAlterations(GameObject player)
    {
        Debug.Log("beep boop you broke your legs off");
        Movement.Instance.CanDoubleJump = false;
        // player.movementSpeed = 1;

    }
}
