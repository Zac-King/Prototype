using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tran_MouseClick : MonoBehaviour {

    // I'm Tran!
    public bool button_appear;
    Vector3 camPos;
	
    void Start()
    {
        camPos = Camera.main.transform.position;
    }

    void Update()
    {
        //Zooms the camera into the card. Had to move the loaction out of the OnMouseDown function
        //to make the camera zoom in only on a right click not left click
        //Dylan Guidry
        RaycastHit hit = new RaycastHit();
        if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100.0f) 
        && hit.transform.tag == "card" && Input.GetMouseButtonDown(1) &&
           (gameObject.GetComponent<Card>().m_cArea == "hand"))
        {
            // set camera to have same position as the card
            //Camera.main.transform.position = transform.position;
            // set z-axis for camera to step back (You can change the value of z if needed)
                //Camera.main.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 10, gameObject.transform.position.z);
            Camera.main.transform.position = gameObject.transform.position + (transform.forward * 25);
            button_appear = true;
        }
    }

    //zoom to the card when left mouse click
    //void OnMouseDown()
    //{
    //    // set camera to have same position as the card
    //    Camera.main.transform.position = transform.position;
    //    // set z-axis for camera to step back (You can change the value of z if needed)
    //    Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, -20f);

    //    button_appear = true;
    //}

    // use this for Button ClickOn() to return the camera back to the original position
    public void zoom_Back()
    {
		button_appear = false;
        Camera.main.transform.position = camPos;
    }

}
