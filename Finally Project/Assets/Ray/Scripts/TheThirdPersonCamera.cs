using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheThirdPersonCamera : MonoBehaviour
{

    public float distanceAway = 1.7f;
    public float distanceUp = 1.3f;
    public float smooth = 2f;              

    private Vector3 m_TargetPosition;      

    Transform follow;      

    void Start()
    {
        follow = GameObject.FindWithTag("Player").transform;
    }

    void LateUpdate()
    {
    
        m_TargetPosition = follow.position + Vector3.up * distanceUp - follow.forward * distanceAway;


        transform.position = Vector3.Lerp(transform.position, m_TargetPosition, Time.deltaTime * smooth);

     
        transform.LookAt(follow);
    }

}
