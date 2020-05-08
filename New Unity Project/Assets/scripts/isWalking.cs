using UnityEngine;

public class isWalking : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();   
    }
    void LateUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isWalking", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("isWalking", false);
        }
        if(Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isWalking", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("isWalking", false);
        }
    }
}
