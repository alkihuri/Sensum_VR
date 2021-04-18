using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysItem : MonoBehaviour
{
    [SerializeField] float preMass = 26.6f; // про эту величину ученик знает, выражается в см^3
    [SerializeField] float preDensity = 7.6f; // эту величину нужно расчитать
    [SerializeField] float preVolume = 3.5f;  // а это получить в результате измерений

    public float PreMass { get => preMass; set => preMass = value; }
}