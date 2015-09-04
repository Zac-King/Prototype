/******
* Author : Eric Mouledoux
*
*
******/
using UnityEngine;
using System.Collections;

public class FSM_PlayerTurn : MonoBehaviour
{
    public enum STATE
    {
        INIT,
        START,
        DRAW,
        PLAY,
        COMBAT,
        END,
    }

    // the current state
    public STATE m_cState = STATE.INIT;
    // the next state
    public STATE m_nSteate = STATE.INIT;

    // checks for a valid transition
    public bool CanTransition(STATE a_next)
    {
        switch (m_cState)
        {
            case STATE.INIT:
                if (a_next == STATE.START)
                    return true;
                break;

            case STATE.START:
                if (a_next == STATE.DRAW)
                    return true;
                break;

            case STATE.DRAW:
                if (a_next == STATE.PLAY)
                    return true;
                break;

            case STATE.PLAY:
                if (a_next == STATE.COMBAT ||
                    a_next == STATE.END)
                    return true;
                break;

            case STATE.COMBAT:
                if (a_next == STATE.END)
                    return true;
                break;

            case STATE.END:
                if (a_next == STATE.INIT)
                    return true;
                break;
        };

        return false;
    }

    // handels what happends after a valid transition
    public bool HandelTransition(STATE a_next)
    {
        if (CanTransition(a_next))
        {
            m_cState = a_next;
            switch (m_cState)
            {
                case STATE.INIT:
                    // do something
                    return true;

                case STATE.START:
                    // do something
                    return true;

                case STATE.DRAW:
                    // do something
                    return true;

                case STATE.PLAY:
                    // do something
                    return true;

                case STATE.COMBAT:
                    // do something
                    return true;

                case STATE.END:
                    // do something
                    return true;
            };
        }

        //////////////////////////Testing
        if (m_cState != m_nSteate)
        {
            print("Invalid Transition");
            m_nSteate = m_cState;
        }
        //////////////////////////End Testing
        return false;
    }

    void Update()
    {
        HandelTransition(m_nSteate);
    }
}