using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionComponent : Interactable
{
    [SerializeField] float detectionDistance = 2f;
    [SerializeField] GameObject text;

    private void OnTriggerStay(Collider other)
    {
        Interactable player = other.GetComponent<Interactable>();
        if (player != null)
            InteractWithInteractable(player);
    }

    public override bool CanInteract(Interactable player)
    {
        return Mathf.Abs((transform.position - player.transform.position).magnitude) <= detectionDistance;
    }

    public override void Interact(Interactable player)
    {
        Debug.Log("doing someting");
    }

    void InteractWithInteractable(Interactable player)
    {
        if (Input.GetKey(KeyCode.E) && CanInteract(player))
            Interact(player);
    }
}
