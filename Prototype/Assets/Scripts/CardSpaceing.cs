using UnityEngine;
using System.Collections.Generic;

public class CardSpaceing : MonoBehaviour
{
    public float m_maxCards;

    public Vector3 m_min;
    public Vector3 m_max;

    public List<GameObject> cards;


    public void SpaceCards(List<GameObject> a_cards)
    {
        for (int i = 0; i < a_cards.Count; ++i)
        {
            a_cards[i].transform.position = m_min + (m_max * (i / (m_maxCards / 2)));
        }
    }

    void GetChildren()
    {
        cards.Clear();

        foreach (Transform c in transform)
        {
            cards.Add(c.gameObject);
        }
    }
    void Start()
    {
        m_min  = (transform.position - transform.right) / 2 * transform.localScale.x;
        m_max  = (transform.position + transform.right) / 2 * transform.localScale.x;
    }

    void Update()
    {
        GetChildren();
        SpaceCards(cards);
    }

}
