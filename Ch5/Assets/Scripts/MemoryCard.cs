﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour {

    [SerializeField] private GameObject cardBack;
    [SerializeField] private SceneController controller;
    private int _id;
    public int id { get { return _id; } }

    public void SetCard(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }
    
    public void OnMouseDown()
    {
        //Debug.Log("testing 1, 2, 3");
        if (cardBack.activeSelf && controller.canReveal)
        {
            //Debug.Log("reveal");
            cardBack.SetActive(false);
            controller.CardRevealed(this);
            
        }
    }
    public void Unreveal()
    {
        cardBack.SetActive(true);
    }
}