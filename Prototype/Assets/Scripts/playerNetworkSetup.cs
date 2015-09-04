using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class playerNetworkSetup : NetworkBehaviour
{
    [SyncVar]private string playerUniqueIdentity;
    private NetworkInstanceId playerNetID;
    private Transform myTransform;

    public override void OnStartLocalPlayer()
    {
        //base.OnStartLocalPlayer();

        GetNetIdentity();
        SetIdentity();
    }

    void Awake()
    {
        myTransform = transform;
    }
    void Start()
    {
        if (isLocalPlayer)
        {
            GetComponent<playerControls>().enabled = true;
        }
    }

    void Update()
    {
        if (myTransform.name == "" || myTransform.name == "Player(Clone)")
        {
            SetIdentity();
        }
    }


    [Client]
    void GetNetIdentity()
    {
        playerNetID = GetComponent<NetworkIdentity>().netId;
        CmdTellServerMyIdentity(MakeUniqueIdentity());
    }

    void SetIdentity()
    {
        if (!isLocalPlayer)
        {
            myTransform.name = playerUniqueIdentity;
        }
        else
        {
            myTransform.name = MakeUniqueIdentity();
        }
    }

    string MakeUniqueIdentity()
    {
        string uniqueIdentity = "Player " + playerNetID.ToString();
        return uniqueIdentity;
    }

    [Command]
    void CmdTellServerMyIdentity(string name)
    {
        playerUniqueIdentity = name;
    }
}
