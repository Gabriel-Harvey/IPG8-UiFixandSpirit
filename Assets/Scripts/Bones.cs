using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bones : MonoBehaviour
{
    public GameObject Spine;
    public GameObject Ribs;
    public Spawner spawner;

    public void Start()
    {
        if (Spawner.value == 2)
        {
            Destroy(Spine);
        }
        else if (Spawner.value >= 3)
        {
            Destroy(Ribs);
            Destroy(Spine);

        }
    }

}
