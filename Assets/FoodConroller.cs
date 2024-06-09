using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodConroller : MonoBehaviour
{
    int ownerID = -1;
    bool needRespawns = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetOwner(GameObject owner)
    {
        ownerID = owner.GetInstanceID();
        needRespawns = false;
        transform.position = owner.transform.position + new Vector3(Random.value>0.5?Random.Range(-4, -2): Random.Range(2, 4), 0f, Random.value > 0.5 ? Random.Range(-4, -2) : Random.Range(2, 4));
    }

    public bool needRespawn()
    {
        return needRespawns;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (ownerID == other.gameObject.GetInstanceID()&& !needRespawns)
        {
            needRespawns = true;
        }
    }
    void Spawn()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
