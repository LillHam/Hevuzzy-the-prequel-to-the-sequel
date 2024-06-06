using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MissleLauncher : MonoBehaviour
{

    public GameObject misslePrefab;
    public float propulsionForce;

    private Transform myTransform;

    private void Start()
    {
        SetInitialReferences();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            SpawnMissile();
        }
    }

    void SpawnMissile()
    {
       GameObject missile = (GameObject) Instantiate(misslePrefab, myTransform.transform.TransformPoint(0, 0, 2f), myTransform.rotation);
        missile.GetComponent<Rigidbody>().AddForce(myTransform.forward * propulsionForce, ForceMode.Impulse);
        //Destory(missile, 3);
    }

    void SetInitialReferences()
    {
        myTransform = transform;
    }
}
