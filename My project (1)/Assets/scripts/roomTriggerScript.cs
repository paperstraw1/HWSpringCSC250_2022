using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomTriggerScript : MonoBehaviour
{
    private Room thisRoom;
   

    // Start is called before the first frame update
    void Start()
    {
        this.thisRoom = new Room();
        CORE.addRoom(this.thisRoom);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            this.thisRoom.setPlayer(CORE.getPlayer());
            print("Player now in room: " + this.thisRoom);
        }
        else if(other.gameObject.tag.Equals("enemy"))
        {
            this.thisRoom.setEnemy(CORE.getEnemy());
            print("The bad guy is now in room: " + this.thisRoom);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
