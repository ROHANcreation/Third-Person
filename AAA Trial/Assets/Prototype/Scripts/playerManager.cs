using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{
    Animator animator;
    inputManager inputManager;
    cameraManager cameraManager;
    playerLocomotion PlayerLocomotion;

    public bool isInteracting;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        inputManager = GetComponent<inputManager>();
        cameraManager = FindObjectOfType<cameraManager>();
        PlayerLocomotion = GetComponent<playerLocomotion>();

    }

    private void Update()
    {
        inputManager.HandleAllInputs();
    }

    private void FixedUpdate()
    {
        PlayerLocomotion.HandleAllMovement();
    }

    private void LateUpdate()
    {
        cameraManager.HandleAllCameraMovement();

        isInteracting = animator.GetBool("isInteracting");
    }
}
