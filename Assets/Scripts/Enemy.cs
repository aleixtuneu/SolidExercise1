using UnityEngine;

public class Enemy : Character
{
    public GameObject player;
    
    void Update()
    {       
        _mb.MoveCharacter(player.transform.position - transform.position); 
    }
}
