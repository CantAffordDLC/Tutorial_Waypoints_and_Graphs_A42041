using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWP1 : MonoBehaviour
{
    Transform goal;

    float speed = 5.0f;
    float accuracy = 1f;
    float rotSpeed = 2f;

    public GameObject wpManager;
    GameObject[] wps;
    GameObject currentNode;
    int currentWP = 0;
    Graph g;
    // Start is called before the first frame update
    void Start()
    {
        wps = wpManager.GetComponent<WPManager>().Waypoints;
        g = wpManager.GetComponent<WPManager>().graph;
        currentNode= wps[0];
    }

    public void GotoHeli()
    {
        g.AStar(currentNode, wps[0]);
        currentWP = 0;
    }

    public void GotoRuin()
    {
        g.AStar(currentNode, wps[1]);
        currentWP = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
