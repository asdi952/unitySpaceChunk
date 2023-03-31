using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ObjI : MonoBehaviour
{
    public Vector3 position{
        set{ transform.position = value;}
        get{ return transform.position;}
    }
    public Quaternion rotation{
        set{ transform.rotation = value;}
        get{ return transform.rotation;}
    }

}
