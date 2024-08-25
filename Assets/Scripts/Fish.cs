using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Fish : MonoBehaviour
{
    public NavMeshAgent _navMeshAgent;
    private Animator _animator;
    [SerializeField] private float movementSpeed;
    public string type;
    public string fishName;

    [SerializeField] private float changePositionTime = 5f;
    public float moveDistance = 10;



    private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        print(_navMeshAgent);
        _navMeshAgent.speed = movementSpeed;
        _animator = GetComponent<Animator>();
        InvokeRepeating(nameof(MoveAnimal), changePositionTime, changePositionTime);
        //StartCoroutine(stopMoveing());
    }

    private void Update()
    {
        //_animator.SetFloat("Speed", _navMeshAgent.velocity.magnitude / movementSpeed);
    }
    public void Stop()
    {
        CancelInvoke();
        print("cansleInvoke");
        _animator.enabled = false;
    }
    Vector3 RandomNavSphere(float distance)
    {
        Vector3 randomDirection = UnityEngine.Random.insideUnitSphere * distance;

        randomDirection += transform.position;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randomDirection, out navHit, distance, -1);

        return navHit.position;
    }
    IEnumerator stopMoveing()
    {
        yield return new WaitForSeconds(10);
        CancelInvoke();
        print("cansleInvoke");
        _animator.enabled = false;
    }

    private void MoveAnimal()
    {
        _navMeshAgent.SetDestination(RandomNavSphere(moveDistance));
        //_navMeshAgent.SetDestination(new Vector3(-9.75f, 3.005f, -5.46f));

    }
}