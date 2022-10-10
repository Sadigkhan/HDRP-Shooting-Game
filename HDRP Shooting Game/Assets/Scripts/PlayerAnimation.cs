using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;
using static UnityEngine.GraphicsBuffer;
using Input = UnityEngine.Input;
//using static System.IO.Enumeration.FileSystemEnumerable<TResult>;

public class PlayerAnimation : MonoBehaviour
{

    [SerializeField] float Speed;
    [SerializeField] Animator animator;
    [SerializeField] GameObject Bullet;
    [SerializeField] Transform FireTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("Run",true);
            animator.SetBool("Left", false);
            animator.SetBool("Right", false);
            animator.SetBool("Backward", false);
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("Run", false);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("Left", false);
            animator.SetBool("Right", false);
            animator.SetBool("Run", false);
            animator.SetBool("Backward", true);
            transform.Translate(Vector3.back * Speed * Time.deltaTime);

        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("Backward", false);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Left", false);
            animator.SetBool("Run", false);
            animator.SetBool("Backward", false);
            animator.SetBool("Right", true);
            transform.Translate(Vector3.right * Speed * Time.deltaTime);

        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("Right", false);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("Run", false);
            animator.SetBool("Right", false);
            animator.SetBool("Backward", false);
            animator.SetBool("Left", true);
            transform.Translate(Vector3.left * Speed * Time.deltaTime);

        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("Left", false);
        }
        else if (Input.GetMouseButton(1))
        {
            animator.SetBool("Aim",true);
        }
        else if (Input.GetMouseButtonUp(1))
        {
            animator.SetBool("Aim", false);
        }


        else if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Bullet, FireTransform.position,transform.rotation);
            //Bullet.transform.rotation = new Vector3(90,0,0);

            //transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, Target.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
            animator.SetBool("Shoot", true);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("Shoot", false);
        }




        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
            //Instantiate(Bullet, FireTransform.position, Quaternion.Euler(new Vector3(0,0,gameObject.transform.localPosition.z)));
            //Instantiate(Bullet, FireTransform.position, transform.rotation);

        }

    }

    
}
