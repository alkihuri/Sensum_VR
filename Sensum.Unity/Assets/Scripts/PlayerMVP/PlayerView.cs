using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private Transform camera;
    private float _toggleAngle = 30f;
    private bool _moveForward = false;
    [SerializeField]private float speed = 3f;
    public AudioSource source;
    private CharacterController cc;


    void Start()
    {
        cc = GetComponent<CharacterController>();
        source = GetComponent<AudioSource>();
    }

//    void Update()
//    {
//        //transform.position = new Vector3(transform.position.x,0.65f,transform.position.z);

//        if (camera.eulerAngles.x > _toggleAngle && camera.eulerAngles.x < 90f)
//        {
//            _moveForward = true;
//        }
//        else
//        {
           
//            _moveForward = false;
//        }

//        if (_moveForward)
//        {
           
//            Vector3 forward = camera.TransformDirection(Vector3.forward);
//            cc.SimpleMove(forward * speed);
//        }
//    }
    private void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
            //  if(_camera.eulerAngles.x>30f && _camera.eulerAngles.x<90f)
        {
            Vector3 moveForward = Camera.main.transform.TransformDirection(Vector3.forward);
            transform.position += moveForward*Time.deltaTime * speed*Time.fixedDeltaTime;
            //   Debug.Log(transform.position);
        }
    }
}
