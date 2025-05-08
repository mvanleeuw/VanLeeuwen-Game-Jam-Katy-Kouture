using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DressManager : MonoBehaviour
{
    // Allows 2D Sprites to be displayed
    public SpriteRenderer dollRenderer;

    // Changes clothing that is shown on Doll
    public void ChangeOutfit(Sprite newOutfit)
    {
        // Tells Unity to change to new outfit or 2D Sprite
        dollRenderer.sprite = newOutfit;
    }

}
