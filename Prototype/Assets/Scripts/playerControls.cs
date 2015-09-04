using UnityEngine;
using System.Collections;

public class playerControls : MonoBehaviour {

    GameObject player;
    float speed = 0.15f;

    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<Transform>().position = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            gameObject.transform.position += Vector3.left * speed; //gameObject.GetComponent<Transform>().position -= new Vector3(1, 0, 0);
        if (Input.GetKey(KeyCode.D))
            gameObject.transform.position += Vector3.right * speed;
        if (Input.GetKey(KeyCode.W))
            gameObject.transform.position += Vector3.forward * speed; //new Vector3(0, 0, 1);
        if (Input.GetKey(KeyCode.S))
            gameObject.transform.position += Vector3.back * speed; //new Vector3(0, 0, 1);
    }
}
