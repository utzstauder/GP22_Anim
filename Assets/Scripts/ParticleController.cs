using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    private ParticleSystem ps;

    private void Awake()
    {
        ps = GetComponentInChildren<ParticleSystem>();
    }

    public void Emit()
    {
        ps.Emit(100);
    }
}
