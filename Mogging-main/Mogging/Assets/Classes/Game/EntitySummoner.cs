using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class NewBehaviourScript : MonoBehaviour
{
    public static List<Enemy> EnemiesInGame;
    public static Dictionary<int, GameObject> EnemyPrefabs;
    public static Dictionary<int, Queue<Enemy>> EnemyObjectPools;
    void Start()
    {
       EnemyPrefabs = new Dictionary< int, GameObject > ();
       EnemyObjectPools = new Dictionary< int, Queue<Enemy>>();
       EnemiesInGame = new List<Enemy> ();  

    }

}
