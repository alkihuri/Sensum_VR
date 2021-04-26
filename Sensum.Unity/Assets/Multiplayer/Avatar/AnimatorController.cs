using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField, Range(0, 10)] float speed;
    [SerializeField] CharacterController parentCharacterController;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = parentCharacterController.velocity.magnitude;
        animator.SetFloat("Speed", speed);
    }
}
