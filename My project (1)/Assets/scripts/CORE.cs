using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CORE : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;

    private static List<GameObject> theRoomsGos = new List<GameObject>();
    private static List<Room> theRooms = new List<Room>();
    private static Player currentPlayer = null;
    private static Enemy currentEnemy = null;

    public static void setPlayer(Player p)
    {
        CORE.currentPlayer = p;
    }

    public static Player getPlayer()
    {
        return CORE.currentPlayer;
    }
    
public static void setEnemy(Enemy e)
    {
        CORE.currentEnemy = e;
    }

    public static Enemy getEnemy()
    {
        return CORE.currentEnemy;
    }
    public static void addRoom(Room theRoom)
    {
        CORE.theRooms.Add(theRoom);
    }

    public static void addRoomGO(GameObject go)
    {
        CORE.theRoomsGos.Add(go);
    }

    public static void display()
    {

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
