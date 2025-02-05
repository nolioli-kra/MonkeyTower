using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    public List<GameObject> buildings;
    public float moveSpeed = 2.0f;
    public float buildingHeight = 10.0f; // Adjust based on your building height
    private float cameraHeight;

    void Start()
    {
        if (Camera.main != null)
        {
            cameraHeight = Camera.main.orthographicSize * 2.0f;
        }
        else
        {
            Console.WriteLine("Warning: No camera found");
        }
    }

    void Update()
    {
        MoveBuildings();
        RecycleBuildings();
    }

    public void MoveBuildings()
    {
        foreach (GameObject building in buildings)
        {
            building.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
    }

    public void RecycleBuildings()
    {
        foreach (GameObject building in buildings)
        {
            if (building.transform.position.y < -cameraHeight)
            {
                float highestY = GetHighestBuildingY();
                building.transform.position = new Vector3(building.transform.position.x, highestY + buildingHeight, building.transform.position.z);
            }
        }
    }

    float GetHighestBuildingY()
    {
        float highestY = float.MinValue;
        foreach (GameObject building in buildings)
        {
            if (building.transform.position.y > highestY)
            {
                highestY = building.transform.position.y;
            }
        }
        return highestY;
    }
}
