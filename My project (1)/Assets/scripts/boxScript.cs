using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class boxScript : MonoBehaviour
{
    private Enemy theEnemy = new Enemy("bad guy");
    private int count;
    private Room currentRoom;
    public GameObject thePlayer;
    private Vector3 playerPosition;
    private Rigidbody rb;
    public float speed = 20f;
    private NavMeshAgent agent; 

    // Start is called before the first frame update
    void Start() //like a constructor
    {
        CORE.setEnemy(theEnemy);
        count = 0;
        rb = this.gameObject.GetComponent<Rigidbody>();
        agent = this.gameObject.GetComponent<NavMeshAgent>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            count++;
            if(count == 3)
            {
                Destroy(this.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(thePlayer.transform.position);
    }
}
