using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple : MonoBehaviour
{
    public void Awake()
    {
        Debug.Log("I awake!");
    }

    public void OnEnable()
    {
        Debug.Log("OnEnable method");
    }

    public void Start()
    {
        Debug.Log("Start method");
    }

    public void Update()
    {
        Debug.Log("Update method");
    }

    public void FixedUpdate()
    {
        Debug.Log("FixedUpdate method");
    }

    public void LateUpdate()
    {
        Debug.Log("LateUpdate method");
    }

    public void OnDisable()
    {
        Debug.Log("OnDisable method");
    }

    public void OnDestroy()
    {
        Debug.Log("OnDestroy method");
    }
}
