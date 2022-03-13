using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    public Sprite defaultSprite;
    public Sprite pressedSprite;

    public KeyCode keyToPress;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
            spriteRenderer.sprite = pressedSprite;
        
        if (Input.GetKeyUp(keyToPress))
            spriteRenderer.sprite = defaultSprite;
    }
}
