/******
* Author : Eric Mouledoux
*
* Manages the different groups of cards - "decks"
******/
using UnityEngine;
using System.Collections.Generic;

public class TableManager : MonoBehaviour
{
    private static TableManager _instance;  // private refrence to class
    public static TableManager instance     // public singleton
    {
        get
        {
            if (_instance == null)                              // if there is no instance of this class
            {                                                   //
                _instance = FindObjectOfType<TableManager>();   // make one
            }
            return _instance;                                   // and return it
        }
    }

    public Dictionary<string, List<GameObject>> m_table =
        new Dictionary<string, List<GameObject>>();             // the table holds all the different types of decks

    public List<GameObject> m_deck = new List<GameObject>();    // deck holds cards not in play
    public List<GameObject> m_hand = new List<GameObject>();    // hand holds cards to be played
    public List<GameObject> m_field = new List<GameObject>();   // field holds card ion play
    public List<GameObject> m_grave = new List<GameObject>();   // grave holds cards that have already been played

    public Transform deck_pos;  // location in 3d space for the deck
    public Transform hand_pos;  // location in 3d space for the hand
    public Transform field_pos; // location in 3d space for the field
    public Transform grave_pos; // location in 3d space for the grave

    void ShuffleDeck(List<GameObject> a_deck)       // randomizes the order of a given deck
    {
        GameObject temp = new GameObject();         // temp variable to assist with swapping

        for (int i = 0; i < a_deck.Count; ++i)      // for each card i given deck
        {                                           //
            int r = Random.Range(0, a_deck.Count);  //pick another random card

            temp = a_deck[i];                       // set temp to the first card
            a_deck[i] = a_deck[r];                  // set the first card to the random card
            a_deck[r] = temp;                       // set the random card to the temp card
        }

    }

    void Start()
    {
        m_table.Add("deck", m_deck);    // creates a deck named "deck"
        m_table.Add("hand", m_hand);    // creates a deck named "hand"
        m_table.Add("field", m_field);  // creates a deck named "field"
        m_table.Add("grave", m_grave);  // creates a deck named "grave"

        ShuffleDeck(m_deck);            // shuffles the "deck" deck
    }

    void Update()
    {

    }

}