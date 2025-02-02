using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This holds all the key elements of the scene and makes the avaible to other scripts
public class Scene : MonoBehaviour
{
    [Header("Scene Information")]
    public string currentLocation;
    public string planetType;
    public int planetSeed;
    public float sceneRadius = 15000;
    public List<string> availibleLocations;
    public string allegiance = "none";

    [Header("The Main Ship")]
    [HideInInspector] public GameObject mainShip;

    [Header("Prefab and Material Pools")]
    [HideInInspector] public Object[] objectPrefabPool;
    [HideInInspector] public Object[] cockpitPrefabPool;
    [HideInInspector] public Object[] particlePrefabPool;
    [HideInInspector] public Object[] tilesPrefabPool;
    [HideInInspector] public Object[] asteroidMaterialsPool;
    [HideInInspector] public GameObject hyperspaceTunnelPrefab;

    [Header("GameObject Pools")]
    [HideInInspector] public List<GameObject> objectPool;
    [HideInInspector] public List<GameObject> asteroidPool;
    [HideInInspector] public List<GameObject> particlesPool;
    [HideInInspector] public List<GameObject> lasersPool;
    [HideInInspector] public List<GameObject> torpedosPool;
    [HideInInspector] public List<GameObject> cockpitPool;
    [HideInInspector] public List<GameObject> tilesPool;
    [HideInInspector] public List<GameObject> tilesSetPool;
    [HideInInspector] public GameObject hyperspaceTunnel;

    [Header("Script Pools")]
    public bool allocatingTargets;
    [HideInInspector] public List<SmallShip> smallShips;
    [HideInInspector] public List<LargeShip> largeShips;
    [HideInInspector] public List<Turret> turrets;

    [Header("Collision Avoidance")]
    [HideInInspector] public bool avoidSmallObjectsRunning;
    [HideInInspector] public bool avoidLargeObjectsRunning;

    [Header("Skybox")]
    public Material space;
    public Material sky;

    [Header("Planet")]
    [HideInInspector] public GameObject planet;
    [HideInInspector] public GameObject planetPivot;

    [Header("Cameras")]
    [HideInInspector] public GameObject mainCamera;
    [HideInInspector] public GameObject planetCamera;
    [HideInInspector] public GameObject starfieldCamera;
    [HideInInspector] public GameObject cockpitCamera;

    [Header("Starfield")]
    [HideInInspector] public GameObject navPointMarker;

    [Header("Avoid Collison")]
    [HideInInspector] public float loadTime;
    [HideInInspector] public bool runAvoidCollision = true;

    [Header("Screen Capture")]
    [HideInInspector] public float pressTime;

    // Update is called once per frame
    void Update()
    {
        SceneFunctions.RecenterScene(mainShip);
        SceneFunctions.RotateStarfieldAndPlanetCamera(this);
        AvoidCollisionsFunctions.AvoidCollision(this);
        SceneFunctions.TakeScreeenShot(this);

        if (allocatingTargets == false)
        {
            Task a = new Task(TargetingFunctions.AllocateTargets(this));
        }

        Shader.SetGlobalFloat("_unscaledTime", Time.unscaledTime);
    }

}

    