using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMVPSingle : MonoBehaviour
{
    [SerializeField] private Transform camera;
    [SerializeField] private float speed = 3f;
    public AudioSource source;
    private CharacterController cc;


    void Start()
    {
        cc = GetComponent<CharacterController>();
        source = GetComponent<AudioSource>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        Vector3 velocity = direction * speed;
        velocity = camera.TransformDirection(velocity);
        cc.Move(velocity * Time.deltaTime);
    }
}
