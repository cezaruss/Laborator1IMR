using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : MonoBehaviour
{

    public Transform cactus;
    private Animator anim; 

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, cactus.position) < 5){
            anim.SetTrigger("animation");
        }
    }
}
