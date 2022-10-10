using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class MutantScript : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [Range(0, 20)]
    [SerializeField] float speed = 5f;
    [SerializeField]Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform);
        if (Vector3.Distance(transform.position, Player.transform.position) <= 3)
        {
            animator.SetBool("Run", false);
            return;
           

        }
        animator.SetBool("Run",true);
        transform.position += transform.forward * speed * Time.deltaTime;

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Bullet"))
        {
            animator.SetBool("Death",true);
            Destroy(gameObject,3f);
        }
       
    }





    //Neden Calismiyor?

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (gameObject.CompareTag("Bullet"))
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}
