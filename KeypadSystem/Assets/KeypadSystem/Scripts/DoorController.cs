using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool lockedByPassword;

    public Animator anim;

    public void OpenClose()
    {
        if (lockedByPassword)
        {
            Debug.Log("Locked by password");
            return;
        }

        anim.SetTrigger("Door");
    }

}
