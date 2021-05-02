﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dead()
    {
        animator.SetBool("dead", true);
        StartCoroutine(ExampleCoroutine());
    }

    public void kill(GameObject g)
    {
        animator.SetBool("kill", true);
        Destroy(g.gameObject);
    }

    IEnumerator ExampleCoroutine()
    {
        //yield on a new YieldInstruction that waits for 2 seconds.
        yield return new WaitForSeconds(2.0f);

        Destroy(gameObject);
    }
}
