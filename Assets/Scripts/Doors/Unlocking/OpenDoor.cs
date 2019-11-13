using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpenDoor : UnlockScript
{
    
    public Animator anim;

    public SpriteRenderer openIcon;
    public SpriteRenderer lockIcon;

    public GameObject TEMP_demoText;

    private bool _isOpen;

    private void Start()
    {
        openIcon.enabled = false;
        TEMP_demoText.SetActive(false);
    }

    public override void Unlock()
    {
        openIcon.enabled = true;
        lockIcon.enabled = false;
        _isOpen = true;
        anim.SetBool("isOpen", _isOpen);
    }

    private void Update()
    {
        if (_isOpen)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
               TEMP_demoText.SetActive(true);
            }
        }
    }

}
