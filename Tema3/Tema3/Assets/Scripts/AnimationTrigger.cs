using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public Animator handAnim;

    // Start is called before the first frame update
    void Start()
    {
        handAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("w")) 
        {
            handAnim.Play("Armature|Wave");
        }

        if(Input.GetKeyDown("o")) 
        {
            handAnim.Play("Armature|Ok");
        }
    }
}
