using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

    public GameObject playerController, playerMenu, gameMenu, inventory, inventoryMenu, weapon;
    public Button[] inventorySlots;
    public Button weaponSlot, equipmentSlot;

    private bool inPlayerMenu, inGameMenu;

    // Use this for initialization
    void Start () {
        inPlayerMenu = false;
        inGameMenu = false;
        //inventorySlots = inventoryMenu.GetComponentsInChildren<Button>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.I) && inGameMenu == false)
        {
            playerMenu.SetActive(!inPlayerMenu);
            inPlayerMenu = !inPlayerMenu;
            playerController.GetComponent<PlayerController>().inMenu = inPlayerMenu;
        }
        if (Input.GetKeyDown(KeyCode.Escape) && inPlayerMenu == false)
        {
            gameMenu.SetActive(!inGameMenu);
            inGameMenu = !inGameMenu;
            playerController.GetComponent<PlayerController>().inMenu = inGameMenu;
        }

        if(weapon.transform.childCount > 0)
        {
            weaponSlot.transform.GetComponentInChildren<Image>().sprite = weapon.transform.GetComponentInChildren<SpriteRenderer>().sprite;
            weaponSlot.transform.GetComponentInChildren<Image>().enabled = true;
        }
        else
        {
            weaponSlot.transform.GetComponentInChildren<Image>().sprite = null;
            weaponSlot.transform.GetComponentInChildren<Image>().enabled = false;
        }
	}

    public void InventoryButton()
    {
        Debug.Log("Pushed inventory button");
    }

    public void WeaponButton()
    {
        if(weapon.transform.childCount > 0)
        {
            weapon.transform.GetChild(0).transform.SetParent(inventory.transform);
        }

    }

    public void EquipmentButton()
    {

        Debug.Log("Pushed equipment button");
    }
}
