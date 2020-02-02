﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupUpgrade : MonoBehaviour
{
    // Slap this on the sprite for an upgrade pickup
    // Use checkmarks to choose what it does

    public bool UpgradesLegs = false;
    public bool UpgradeTyres = false;
    public bool FixesEyes = false;
    public GameEvent FadeOut;

    public ArrayList upgrades = new ArrayList();

    public PickupUpgrade()
    {
        //if (UpgradesLegs) upgrades.Add(new LegsUpgrade());
    }

    private void Start()
    {

        if (UpgradesLegs) upgrades.Add(new LegsUpgrade());
        if (UpgradeTyres) upgrades.Add(new TyreFix());
        if (FixesEyes) upgrades.Add(new EyesFixed());
    }

    public void ApplyAllUpgrades(GameObject player)
    {
        AudioManager.Instance.Play("Repair");
        foreach (UpgradeItem upgrade in upgrades)
        {
            FadeOut.Raise();
            if (FixesEyes)
            {
                StartCoroutine(Eyes(player));
            }
            upgrade.ApplyAlterations(player);            
        }
    }
    public void RevertAllUpgrades(GameObject player)
    {
        foreach (UpgradeItem upgrade in upgrades)
        {
            FadeOut.Raise();
            upgrade.RevertAlterations(player);
        }
    }



    public IEnumerator Eyes(GameObject player)
    {
        yield return new WaitForSeconds(2f);
        player.transform.GetChild(0).gameObject.SetActive(false);
        StopAllCoroutines();
    }
}
