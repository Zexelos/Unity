using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public virtual bool CanInteract(Interactable player)
    {
        return true;
    }

    public virtual void Interact(Interactable player)
    {

    }
}
