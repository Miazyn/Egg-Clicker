using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public float lifetime = 1f;

    private void Start()
    {
        Animator animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Destroy(gameObject, lifetime);
    }
}
