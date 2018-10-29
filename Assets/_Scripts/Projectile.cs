using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{

    private BoundCheck bndCheck;

    void Awake()
    {
        bndCheck = GetComponent<BoundCheck>();
    }

    void Update()
    {
        if (bndCheck.offUp)
        {                                        // a
            Destroy(gameObject);
        }
    }
}