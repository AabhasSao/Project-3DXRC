﻿using UnityEngine;
using UnityEngine.EventSystems;

public class PlaySFX : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    public void OnPointerEnter(PointerEventData eventData) {
        FindObjectOfType<AudioManager>().Play("hoverSFX");
        Debug.Log("HI");
    }

    public void OnPointerClick(PointerEventData eventData) {
        FindObjectOfType<AudioManager>().Play("clickSFX");
    }
}
