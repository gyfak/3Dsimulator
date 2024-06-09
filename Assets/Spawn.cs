using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    public float spawn_radius = 5f;

    public GameObject prefab;

    public Transform spawn_point;

    private List<List<bool>> spawn_sectors = new List<List<bool>>();

    [SerializeField]
    Slider sise_slider;
    [SerializeField]
    Slider units_slider;
    [SerializeField]
    Slider spawn_slider;


    int size = 2;
    int units_count = 1;
    int units_spawn = 1;

    int net_step = 5;
    float step = 0f;
    float timer = 0f;

    public void StartSimulation()
    {
        gameObject.SetActive(true);
        step = 1f / net_step;        

        size = (int)sise_slider.value;
        units_count = (int)units_slider.value;
        units_spawn = (int)spawn_slider.value;

        transform.localScale = transform.localScale * size;

        for (int i = 0; i < size * net_step; i++)
        {
            spawn_sectors.Add(new List<bool>());
            for (int j = 0; j < size * net_step; j++)
            {
                spawn_sectors[i].Add(false);
            }
        }
        StartCoroutine("Circle_spawn");
    }

    void Update()
    {
        //timer+= Time.timeScale * Time.deltaTime
    }


    IEnumerator Circle_spawn()
    {
        GameObject parent = new GameObject();
        int spawn_count = units_count;
        while (spawn_count>0)
        {
            spawn_count--;
            GameObject obj = Instantiate(prefab, spawn_point.position + Random.insideUnitSphere * spawn_radius* size, Quaternion.identity, parent.transform);
            obj.transform.position = new Vector3(obj.transform.position.x, 1.2f, obj.transform.position.z);
            yield return new WaitForSeconds( 1f/ Time.timeScale * units_spawn);
        }
    }
}