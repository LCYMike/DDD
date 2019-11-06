using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconPopUp : MonoBehaviour
{
    public GameObject interactIcon;


    private void Awake()
    {
        interactIcon.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            interactIcon.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            interactIcon.SetActive(false);
        }
    }
}
