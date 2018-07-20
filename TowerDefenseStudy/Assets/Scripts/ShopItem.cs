﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour {

    [Header("UI Objects")]
    public Text objNameText;
    public Text objCostText;
    private Image _objImage;
    private Button _objButton;

    [Header("Item Details")]
    public string itemName;
    public Sprite itemSprite;
    public int itemCost;
    public GameObject itemPrefab;
    public bool isUnlocked = true;

    public Color32 lockedColor;
    public Color32 unLockedColor;

    private int iD;
    public int ID{
        get{
            return iD;
        }
        set{
            this.iD = value;
        }
    }

	private void Start()
	{
        _objImage = GetComponent<Image>();
        _objButton = GetComponent<Button>();

        objNameText.text = itemName;
        objCostText.text = itemCost.ToString();
        if(itemSprite != null){
            _objImage.sprite = itemSprite;

        }
	}

    public void Activate(){
        _objButton.interactable = true;
    }
    public void Deactivate(){
        _objButton.interactable = false;
    }

    public void Unlock(){
        _objImage.color = unLockedColor;
        _objButton.interactable = true;
    }
}
