using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject food = null;

    [SerializeField]
    float speed = 10f;

    GameObject _food = null;
    FoodConroller _fc = null;
    void Start()
    {
        GenerateFood();
    }

    void GenerateFood()
    {
        if (_food == null)
        {
            _food = Instantiate(food);
            _fc = _food.GetComponent<FoodConroller>();
        }
        _food.transform.SetParent(gameObject.transform.parent, false);
        _fc.SetOwner(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (_food != null)
        {
            if (_fc.needRespawn())
            {
                GenerateFood();
            } 
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, _food.transform.position, Time.timeScale * speed * Time.deltaTime);
            }                
        }
    }
}
