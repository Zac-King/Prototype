/******
* Author : Eric Mouledoux
*
*
******/
using UnityEngine;
using System.Collections.Generic;

public class Card : MonoBehaviour
{
    public string m_name = "";   // card properties
    public string m_cArea = "";   // what makes a card
    public string m_nArea = "";

    public void MoveCardTo(string newDeck)
    {
        if (newDeck != m_cArea)         // checks to see if the card actually moved
        {                               // if yes..
            newDeck = newDeck.ToLower();                                              // make sure the end are is correctly formatted
            List<GameObject> temp = null;                                   //
            if (TableManager.instance.m_table.TryGetValue(newDeck, out temp))       // and make sure the end area exist
            {                                                                       // if yes...
                TableManager.instance.m_table[newDeck].Add(gameObject);             // add card to new area
                TableManager.instance.m_table[m_cArea].Remove(gameObject);          // and remove it from the old one
                m_cArea = newDeck;                                                  // set current area to new area

                Transform parent = transform;

                switch (m_cArea)                                            // checks what area card was just moved to
                {                                                           //
                    case "deck":                                            //
                        parent = TableManager.instance.deck_pos;   //
                        break;                                              //
                    case "hand":
                        parent = TableManager.instance.hand_pos;   //
                        break;                                              //
                    case "field":
                        parent = TableManager.instance.field_pos;  //
                        break;                                              //
                    case "grave":
                        parent = TableManager.instance.grave_pos;  //
                        break;                                              //
                };

                transform.parent = null;
                transform.position = parent.position;                        // and visually moves it there in 3d space
                transform.rotation = parent.rotation;
                transform.parent = parent;
            }
            //else                                                              // if the area is NOT valid
            //{                                                                 //
            //    print("ERROR, PATH " + from.ToUpper() + " DOES NOT EXIST");   // display error
            //}
        }
    }

    void Update()
    {
        MoveCardTo(m_nArea);
    }
}