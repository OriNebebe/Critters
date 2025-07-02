using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardInteractionManager : MonoBehaviour, IPointerUpHandler, IPointerDownHandler, IPointerMoveHandler
{
    //SlotChecker
    public SlotsColliderManager colliderName;
    SlotsColliderManager prevName;

    public BugCardSO bugCardSO;
    public Sprite bugSprite;
    public GameObject bugPrevPrefab;
    public GameObject bugPrefab;

    public bool ColliderCheck = false;
    public bool CardSelected = false;
    GameObject bug;
    public void OnPointerDown(PointerEventData eventData)
    {
        switch (CardSelected)
        {
            case false:
                bug = Instantiate(bugPrevPrefab, Vector2.zero, Quaternion.identity);
                bug.GetComponent<SpriteRenderer>().sprite = bugSprite;

                bug.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                CardSelected = true;
                break;
            case true:
                Destroy(bug);
                CardSelected = false;
                break;
        }
    }
    public void OnPointerUp(PointerEventData eventData)
    {
    }
    public void OnPointerMove(PointerEventData eventData)
    {
        //Script to take the card and make the sprite follow the cursor
        if (prevName != colliderName || prevName == null)
        {
            ColliderCheck = false;
            prevName = colliderName;
        }
    }
}
