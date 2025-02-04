using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraMove : MonoBehaviour
{
    float velocityMove = 0.01f;
    bool isMove = false;
    public List<Transform> edges = new List<Transform>();

    private float minX = -20f;
    private float maxX = 20f;
    private float minZ = -15f;
    private float maxZ = 20f;


}