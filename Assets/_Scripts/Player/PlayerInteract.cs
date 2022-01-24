using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    IInteractable interactable;
    bool isInInteractiveZone;
    PlayerMovement playerMovement;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        ButtonToInteract();
    }

    void ButtonToInteract() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isInInteractiveZone)
            {
                interactable?.Interact();
                //playerMovement.enabled = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        interactable = collision.GetComponent<IInteractable>();
        isInInteractiveZone = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interactable = collision.GetComponent<IInteractable>();
        isInInteractiveZone = false;
        interactable?.ExitInteration();
    }
}
