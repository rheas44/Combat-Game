using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//template to create subclasses for interactable items (chest, lever, lightswitch, etc.)
public abstract class Interactable : MonoBehaviour
{
    //message displayed to player when looking at an interactable.
    public string promptMessage;
    //created a template method pattern
    //function called from our player
    public void BaseInteract() {
        Interact();
    }
    protected virtual void Interact() {
        //no code written in this function
        //template function to be overridden by subclasses
    }
}
