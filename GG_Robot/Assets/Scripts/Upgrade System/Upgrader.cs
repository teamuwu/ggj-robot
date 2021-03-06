﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrader : MonoBehaviour
{
    // Player upgrader, handles collisions & triggers picked up upgrade items to alter the game

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PickupUpgrade pickup = collision.gameObject.GetComponent<PickupUpgrade>();
        if (pickup != null)
        {
            Debug.Log("player trigger with pickup");
            pickup.ApplyAllUpgrades(this.gameObject); // attached to player
        }
    }

}
