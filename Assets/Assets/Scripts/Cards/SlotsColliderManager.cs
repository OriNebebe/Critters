using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SlotsColliderManager : MonoBehaviour
{
    public GameObject bugPrev;
    public GameObject bug;

    public bool slotted;
    void OnMouseOver()
    {
        //this makes it so when you hover over emply tiles the card shows a preview.

        foreach (CardInteractionManager item in GameObject.FindObjectsOfType<CardInteractionManager>())
        {
            item.colliderName = this.GetComponent<SlotsColliderManager>();
            item.ColliderCheck = true;
        }
        if (bugPrev == null)
        {
            if (GameObject.FindGameObjectWithTag("BugPreview") != null)
            {
                bugPrev = GameObject.FindGameObjectWithTag("BugPreview");
                bugPrev.transform.SetParent(this.transform);
                bugPrev.transform.localPosition = Vector2.zero;
            }
        }
    }

    private void OnMouseDown()
    {
        // This checks if the tile is occupied by another bug.
        // if not - it places the bug on the tile.
        switch (slotted)
        {
            case false:
                if (bugPrev != null)
                {
                    slotted = true;
                    Destroy(bugPrev);
                    //else add play audio "valid" - yet to be implemented
                }
                break;

            case true:
                if (bugPrev != null)
                {
                    Debug.Log("Occupied slot");
                    //else add play audio "invalid" - yet to be implemented
                }
                break;

        }
    }
    private void OnMouseExit()
    {
        // This makes it so when you move over to another tile, the preview disappears from the previous tile.
        // It also makes it possible to hover over the same tile again later

        bugPrev = null;
    }
}
