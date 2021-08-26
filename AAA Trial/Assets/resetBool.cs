using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetBool : StateMachineBehaviour
{
    public string isInteractingBool;
    public bool isIntractingStatus;
    
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool(isInteractingBool, isIntractingStatus);
        
    }


}
