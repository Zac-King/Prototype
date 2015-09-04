using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NetworkTestControlls : NetworkBehaviour
{


    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<Transform>().position = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    [ClientCallback]
    void Update()
    {
        if (!isLocalPlayer)
            return;

        if (Input.GetKeyDown(KeyCode.A))
            CmdMove(new Vector3(-1, 0, 0));
        else if (Input.GetKeyDown(KeyCode.D))
            CmdMove(new Vector3(1, 0, 0)); 
        else if (Input.GetKeyDown(KeyCode.W))
            CmdMove(new Vector3(1, 0, 0));
        else if (Input.GetKeyDown(KeyCode.S))
            CmdMove(new Vector3(-1, 0, 0));


    }

    [Command]
    public void CmdMove(Vector3 dir)
    {

        gameObject.GetComponent<Transform>().position += dir;
    }



}
