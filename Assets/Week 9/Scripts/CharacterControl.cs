using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControl : MonoBehaviour
{
    public TMPro.TextMeshProUGUI currentSelection;
    public static CharacterControl Instance;
    public static Villager SelectedVillager { get; private set; }

    public Dropdown characterDropdown;

    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
        Instance.currentSelection.text = villager.ToString();
    }

    public void SetSelectedVillagerFromDropdown(int dropdownValue)
    {
        switch (dropdownValue)
        {
            case 0:
                SetSelectedVillager( new Merchant());
                break;
            case 1:
                SetSelectedVillager(new Archer());
                break;
            case 2:
                SetSelectedVillager(new Thief()); 
                break;
            case 3:
                SetSelectedVillager(null); 
                break;
            default:
                Debug.LogError("Invalid dropdown value!");
                break;
        }
    }

    public void Start()
    {
        Instance = this;
    }

}
