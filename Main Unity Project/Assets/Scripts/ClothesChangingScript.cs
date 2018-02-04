using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesChangingScript : MonoBehaviour {

    public Sprite defaultSprite;
    public Sprite redSprite;
    public Sprite stylishSprite;
    public SpriteRenderer defaultRenderer;
    public GameObject buttonClicked;

    void OnMouseDown()
    {
        if(buttonClicked.name == "DiamondButtonDefault")
        {
            defaultRenderer.sprite = defaultSprite;
        }
        else if (buttonClicked.name == "DiamondButtonRed")
        {
            defaultRenderer.sprite = redSprite;
        }
        else if (buttonClicked.name == "DiamondButtonStylish")
        {
            defaultRenderer.sprite = stylishSprite;
        }
    }
}
