﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gril_trigger : MonoBehaviour
{
    public GameObject gril;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(player.transform.position, transform.position) < 50)
        {
            gril.SetActive(true);
        }
    }
}
