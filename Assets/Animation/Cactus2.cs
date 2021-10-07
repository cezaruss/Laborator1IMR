using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus2 : MonoBehaviour
{
    public Transform cactus2;
    private Animator anim2; 

    // Start is called before the first frame update
    void Start()
    {
        anim2 = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, cactus2.position) < 5){
            anim2.SetTrigger("animation");
        }
    }
}
