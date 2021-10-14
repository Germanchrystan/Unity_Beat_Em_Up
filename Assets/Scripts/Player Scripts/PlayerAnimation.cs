using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void Walk(bool move)
    {
        anim.SetBool("Movement", move);
    }

    public void Punch1()
    {
        anim.SetTrigger("Punch1");
    }

    public void Punch2()
    {
        anim.SetTrigger("Punch2");
    }

    public void Punch3()
    {
        anim.SetTrigger("Punch3");
    }

    public void Kick1()
    {
        anim.SetTrigger("Kick1");
    }

    public void Kick2()
    {
        anim.SetTrigger("Kick2");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
