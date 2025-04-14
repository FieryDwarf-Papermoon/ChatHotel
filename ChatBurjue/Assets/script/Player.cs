using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Player : MonoBehaviour
{
    public float moveSpeed = 10;
    public float turnSpeed = 80;
    [SerializeField] private Animator animator;
    private CharacterController controller;
    private NavMeshAgent myAgent;
    public GameObject Text3D;

    public Vector3 lastpos;
    public float mejpos = 0;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        myAgent = GetComponent<NavMeshAgent>();
        lastpos = gameObject.transform.position;
        Text3D.SetActive(true);
        Vector3 v = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
        Text3D.transform.position = v;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit placeInfo;
            if (Physics.Raycast(ray, out placeInfo))
            {
                myAgent.SetDestination(placeInfo.point);
            }
            
        }

        mejpos += Mathf.Abs(transform.position.x - lastpos.x)+ Mathf.Abs(transform.position.y - lastpos.y)+ Mathf.Abs(transform.position.z - lastpos.z);
        lastpos = gameObject.transform.position;
        if (mejpos > 20)
        {
            mejpos = 0;
            Text3D.SetActive(true);
            Vector3 v = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z) ;
            Text3D.transform.position = v;
        }

        animator.SetFloat("Speed", myAgent.velocity.magnitude);


        //float horizont = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");
        //animator.SetFloat("Speed", Mathf.Abs(vertical));
        //transform.Rotate(0, horizont, 0);
        //Vector3 moveDirection = new Vector3(0f, 0.0f, vertical);
        //moveDirection = transform.TransformDirection(moveDirection);
        //moveDirection *= moveSpeed;

        //controller.Move(moveDirection * Time.deltaTime);
    }
}
