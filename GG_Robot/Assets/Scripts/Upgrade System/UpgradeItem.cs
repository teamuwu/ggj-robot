﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UpgradeItem : MonoBehaviour
{
    public abstract void ApplyAlterations(GameObject player);
    public abstract void RevertAlterations(GameObject player);
}
