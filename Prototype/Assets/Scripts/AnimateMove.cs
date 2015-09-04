using UnityEngine;
using System.Collections;

public class AnimateMove : MonoBehaviour
{
    public GameObject animateMoveTo;
    public int speed;
    public float closenessRadius;
    float dt = 0;
    
	
	// Update is called once per frame
	void Update ()
    {
        dt = Time.deltaTime;
        if(Distance(transform.position, animateMoveTo.transform.position) > closenessRadius)
        gameObject.transform.position += ((transform.position + animateMoveTo.transform.position) / 100) * dt *speed;
	}

    float Distance(Vector3 from, Vector3 to)
    {
        float r;

        r = Mathf.Sqrt(((from.x + to.x) * (from.x + to.x)) + ((from.y + to.y) * (from.y + to.y)));

        return r;
    }
}
