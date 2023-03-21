using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrimitives : MonoBehaviour
{

    [SerializeField] private GameObject spherePrefab;
    [SerializeField] private GameObject capsulePrefab;
    [SerializeField] private GameObject cubePrefab;
    [SerializeField] private GameObject cylinderPrefab;

    [SerializeField] private int numOfPrimitives = 100;

    [SerializeField] private float maxX = 20f;
    [SerializeField] private float maxY = 20f;
    [SerializeField] private float maxZ = 20f;
    
    // Start is called before the first frame update
    void Start()
    {
        CreateNewPrimitives();
    }

    // Update is called once per frame
    public void CreateNewPrimitives()
    {
        for (int i = 0; i < numOfPrimitives; i++)
        {
            Vector3 Position = new Vector3(Random.Range(-maxX, maxX), Random.Range(-maxY, maxY),
                Random.Range(-maxZ, maxZ));
            int a = Random.Range(0, 4);
            switch (a)
            {
                case 0: Instantiate(spherePrefab, Position, Quaternion.identity);
                    break;
                case 1: Instantiate(capsulePrefab, Position, Quaternion.identity);
                    break;
                case 2: Instantiate(cubePrefab, Position, Quaternion.identity);
                    break;
                default: Instantiate(cylinderPrefab, Position, Quaternion.identity);
                    break;
                    
            }
        }
    }
}
