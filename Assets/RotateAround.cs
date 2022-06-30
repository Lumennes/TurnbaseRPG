using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    private Transform _transform;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        _transform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        _transform.RotateAround(target.transform.position, Vector3.up, 20 * Time.deltaTime);
    }
}
