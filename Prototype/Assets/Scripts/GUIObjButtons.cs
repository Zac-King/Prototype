//Dylan Guidry
//August 3, 2015
//GUIObjButtons script
/*
    Will be attached to objects that need a button placed on them to 
    perfomr actions. If you need help with implementing this just ask me
    and I'll walk you through how to do it.
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class GUIObjButtons : MonoBehaviour
{
    public bool isDisplay = false;
    //temporary checks to see what objects the button is on
    public string location;
    
	// Use this for initialization
	void Start ()
    {
        foreach(GameObject _button in datButton)
        _button.SetActive(false);
	    //sets the button to not active on game start so that it does not appear
	}
	
	// Update is called once per frame
	void Update ()
    {
        foreach (GameObject _button in datButton)
        {
            if (location == "deck" && isDisplay)
                _button.SetActive(true);
            else
                _button.SetActive(false);

            if(location != "deck")
            switch (gameObject.GetComponent<Card>().m_cArea)
            {
                case "hand": //location is hand
                    if (isDisplay == true)
                    {

                        if (GetComponent<Tran_MouseClick>().button_appear == true)
                        {
                            datButton[1].SetActive(true);
                            datButton[0].SetActive(false);
                        }
                        else
                        {
                            datButton[1].SetActive(false);
                            datButton[0].SetActive(true);
                        }

                    }
                    else
                    {
                        _button.SetActive(false);
                    }
                    break;
                case "field": //location is field
                        _button.SetActive(false);             
                    break;
                case "grave": //location is grave
                    break;
            }


        }

        //checks if the isDisplay boolean is true or false and this will determine if
        //The button should be shown to the screen
        //need to do more stuff
	}

    public void shuffle()
    {
        TableManager.instance.ShuffleDeck(TableManager.instance.m_deck);
    }

    public void draw(string n)
    {
            TableManager.instance.m_deck[0].GetComponent<Card>().MoveCardTo(n);
    }

    public void buttonActions(string n)
    {
        print(n);
        /*
        function calls go in here for the actions that should be performed 
        when the button is pressed
        */
    }

    void OnMouseOver()
    {
        isDisplay = true; //when the mouse is over the object sets isDisplay to true
    }

    void OnMouseExit()
    {
        isDisplay = false; //when the mouse is no longer hoovering over the object
                           //we set isDisplay to false
    }

    public GameObject[] datButton; //gamebject refrence to the button associated with an function
                                 //we wish to execute. Objects now have multiple buttons for multiple
                                 //fucntions 

    
}
