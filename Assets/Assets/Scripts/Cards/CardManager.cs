using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class CardManager : MonoBehaviour
{
    #region Parameters
    [Header("Cards Parameters")]

    public int numberOfCards;

    public BugCardSO[] bugCardsSO;
    public GameObject cardPrefab;
    public Transform cardHolderTransform;

    [Header("Bug Parameters")]

    public GameObject[] bugCards;
    public Texture2D bugIcon;
    public int cost;
    public float cooldown;
    #endregion

    private void Start()
    {
        // Adds the amount of cards you added into the roaster.

        numberOfCards = bugCardsSO.Length;
        bugCards = new GameObject[numberOfCards];

        for (int i = 0; i < numberOfCards; i++)
        {
            AddBugCard(i);
        }
    }

    public void AddBugCard(int index)
    {

        GameObject card = Instantiate(cardPrefab, cardHolderTransform);
        CardInteractionManager cardInteractionManager = card.GetComponent<CardInteractionManager>();

        cardInteractionManager.bugCardSO = bugCardsSO[index];
        cardInteractionManager.bugSprite = bugCardsSO[index].bugSprite;

        bugCards[index] = card;

        //Variables
        bugIcon = bugCardsSO[index].icon;
        cost = bugCardsSO[index].cost;
        cooldown = bugCardsSO[index].cooldown;

        //Card UI updater
        card.GetComponentInChildren<RawImage>().texture = bugIcon;
        card.GetComponentInChildren<TMP_Text>().text = "" + cost;

        //Adding new card into the roaster
        index++;
    }
}
