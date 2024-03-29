using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


[System.Serializable]
public struct Link
{
    public enum direction { UNI, BI }
    public GameObject node1;
    public GameObject node2;
    public direction dir;
}
public class WPManager : MonoBehaviour
{
    public GameObject[] Waypoints;
    public Link[] Links;
    public Graph graph = new Graph();
    // Start is called before the first frame update
    void Start()
    {
        if (Waypoints.Length > 0)
        {
            foreach (GameObject wp in Waypoints)
            {
                graph.AddNode(wp);
            }
            foreach (Link l in Links)
            {
                graph.AddEdge(l.node1, l.node2);
                if (l.dir == Link.direction.BI)
                {
                    graph.AddEdge(l.node2, l.node1);
                }

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
