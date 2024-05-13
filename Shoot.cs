using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform shootingPoint;
    public GameObject bulletPrefab;
    private GameObject greenParticles;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
            Instantiate(greenParticles, transform.position, transform.rotation);
        }
    }
}
