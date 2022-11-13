using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{

    [SerializeField] private Transform[] Positions;
    [SerializeField] private float moveSpeed;
    private int PointAIndex;
    private Transform PointA;

    
    
    void Start()
    {
        PointA = Positions[0];
        
    }
    void Update()
    {
        MoveEnemyObj();

    }

    void MoveEnemyObj()
    {
        if (transform.position == PointA.position)
        {
            PointAIndex++;
            if (PointAIndex >= Positions.Length)
            {
                PointAIndex = 0;
            }
            
            PointA = Positions[PointAIndex];
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, PointA.position, moveSpeed * Time.deltaTime);
        }
        
        
    }
    
}
