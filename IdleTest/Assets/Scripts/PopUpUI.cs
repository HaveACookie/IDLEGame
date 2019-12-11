using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpUI : MonoBehaviour
{
    public GameObject info;
    // Start is called before the first frame update
    void Start()
    {
        info.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onMouseOver ()
    {
        info.SetActive(true);
        Debug.Log("its working");
    }
    void onMouseExit()
    {
        info.SetActive(false);
    }
}
