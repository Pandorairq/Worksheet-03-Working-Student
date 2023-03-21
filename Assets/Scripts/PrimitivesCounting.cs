using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimitivesCounting : MonoBehaviour
{
    private static int rayNumX = 400;
    private static int rayNumY = 200;
    private static Camera camera;
    private static List<Transform> alreadyHit;

    private void Start()
    {
        camera = Camera.main;
    }

     public static void CountPrimitives()
    {
        alreadyHit = new List<Transform>();
        int numOfPrimitives = 0;
        
        for (int i = 0; i <= rayNumX; i++)
        {
            for (int j = 0; j <= rayNumY; j++)
            {
                Ray ray = camera.ViewportPointToRay(new Vector3((float)i / rayNumX, (float)j / rayNumY, 0.0f));
                RaycastHit raycastHit = new RaycastHit();
                
                if (Physics.Raycast(ray,out raycastHit,1000f) && !alreadyHit.Contains(raycastHit.transform))
                {
                    numOfPrimitives++;
                    alreadyHit.Add(raycastHit.transform);
                }
            }
        }
        Debug.Log("Die Kamera sieht gerade " + numOfPrimitives + " Meshes!");
    }
}
