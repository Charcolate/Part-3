using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public static Villager SelectedVillager { get; private set; }
    public TextMeshProUGUI typeOfSelectedVillager;
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
    }

    private void Update()
    {
        if (SelectedVillager != null)
        {
            typeOfSelectedVillager.text = "Type: " + SelectedVillager.CanOpen().ToString();
        }
        else
        {
            typeOfSelectedVillager.text = "Type: None";
        }
    }
}
