using UnityEngine;
using System.Collections;

public class FSM_GamePlay : MonoBehaviour
{
    /// <Game Play FSM>
    /// Control the flow  
    /// 

    enum States /// PlaceHolders
    {
        STATE1,
        STATE2,
        STATE3,
        STATE4
    }

    States currentState = States.STATE1;

    bool CheckTransistion( States to)
    {
        /// Check Fails if transisiton attempt is the same af current state
        if (currentState == to)
        {
            print("GamePlay Transistion Failed.\nTransistion to current state is not valid.\nSee <FSM_GamePlay.cs>");
            return false;
        }

        switch (currentState)
        {
            case (States.STATE1):
                    /// PlaceHolder
                    print("GamePlay Transistion Check Passed.");
                    if (to == States.STATE2)
                    return true;
                break;

            case (States.STATE2):
                    /// PlaceHolder
                    print("GamePlay Transistion Check Passed.");
                    if (to == States.STATE3)
                    return true;
                break;

            case (States.STATE3):
                    /// PlaceHolder
                    print("GamePlay Transistion Check Passed.");
                    if (to == States.STATE4)
                        return true;
                break;

            case (States.STATE4):
                    /// PlaceHolder
                    print("GamePlay Transistion Check Passed.");
                    if (to == States.STATE1)
                        return true;
                break;

            default:
                break;
        }
        return false;
    }

    void HandleTransistion(States to)
    {
        if (CheckTransistion(to))
        {
            switch(to)
            {
                case (States.STATE1):
                    /// PlaceHolder
                    PrintDebugText(currentState, to);
                    currentState = States.STATE1;
                    break;

                case (States.STATE2):
                    /// PlaceHolder
                    PrintDebugText(currentState, to);
                    currentState = States.STATE2;
                    break;

                case (States.STATE3):
                    /// PlaceHolder
                    PrintDebugText(currentState, to);
                    currentState = States.STATE3;
                    break;

                case (States.STATE4):
                    /// PlaceHolder
                    PrintDebugText(currentState, to);
                    currentState = States.STATE4;
                    break;

                default:
                    print("GamePlay Transistion Failed.\nHandle Transistion returned False.\nSee < FSM_GamePlay.cs > ");
                    break;
            }
        }
    }

    void PrintDebugText(States from, States to)
    {
        switch (from)
        {
            
            case (FSM_GamePlay.States.STATE1):
            {
                switch(to)
                    {
                        case (FSM_GamePlay.States.STATE2):
                            {
                                print("Transistioning From <STATE1> to <STATE2>");
                            }break;
                        case (FSM_GamePlay.States.STATE3):
                            {
                                print("Transistioning From <STATE1> to <STATE3>");
                            }
                            break;
                        case (FSM_GamePlay.States.STATE4):
                            {
                                print("Transistioning From <STATE1> to <STATE4>");
                            }
                            break;
                    }
            }break;

            case (FSM_GamePlay.States.STATE2):
                {
                    switch (to)
                    {
                        case (FSM_GamePlay.States.STATE1):
                            {
                                print("Transistioning From <STATE2> to <STATE1>");
                            }break;
                        case (FSM_GamePlay.States.STATE3):
                            {
                                print("Transistioning From <STATE2> to <STATE3>");
                            }break;
                        case (FSM_GamePlay.States.STATE4):
                            {
                                print("Transistioning From <STATE2> to <STATE4>");
                            }break;
                    }
                }break;

            case (FSM_GamePlay.States.STATE3):
                {
                    switch (to)
                    {
                        case (FSM_GamePlay.States.STATE1):
                            {
                                print("Transistioning From <STATE3> to <STATE1>");
                            }break;
                        case (FSM_GamePlay.States.STATE2):
                            {
                                print("Transistioning From <STATE3> to <STATE2>");
                            }break;
                        case (FSM_GamePlay.States.STATE4):
                            {
                                print("Transistioning From <STATE3> to <STATE4>");
                            }break;
                    }
                }break;
            case (FSM_GamePlay.States.STATE4):
                {
                    switch (to)
                    {
                        case (FSM_GamePlay.States.STATE1):
                            {
                                print("Transistioning From <STATE4> to <STATE1>");
                            }break;
                        case (FSM_GamePlay.States.STATE2):
                            {
                                print("Transistioning From <STATE4> to <STATE2>");
                            }break;
                        case (FSM_GamePlay.States.STATE3):
                            {
                                print("Transistioning From <STATE4> to <STATE3>");
                            }break;
                    }
                }break;

            default:
                break;
        }
    
    }

    //void Start()
    //{
    //    HandleTransistion(States.STATE2);
    //}

}
