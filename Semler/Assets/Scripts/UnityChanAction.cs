using System.Collections.Generic;
using UnityEngine;

public class UnityChanAction : MonoBehaviour
{
    // アニメーター各ステートへの参照
    static int idleState = Animator.StringToHash("Base Layer.idle");
    static int runState = Animator.StringToHash("Base Layer.run");
    static int shootState = Animator.StringToHash("Base Layer.shoot");
    //static int damageState = Animator.StringToHash("Base Layer.damage");
    //static int deadState = Animator.StringToHash("Base Layer.dead");

    //public bool isDead = false;
    //public bool isDamage = false;

    //public AudioClip audioAttack;
    //public AudioClip audioDamage;
    //private AudioSource audioSource;



    private AnimatorStateInfo stateInfo;
    private Animator animator;
    private Vector3 velocity;


    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        // return flag to false
        if (stateInfo.fullPathHash == shootState)
        {
            if (!animator.IsInTransition(0))
            {
                animator.SetBool("isShoot", false);
            }
        }
        else if (stateInfo.fullPathHash == runState)
        {
            if (!animator.IsInTransition(0))
            {
                //
            }
        }
    }

}