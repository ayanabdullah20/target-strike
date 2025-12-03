using UnityEngine;
using Unity.Mathematics;
using StarterAssets;
public class ActiveWeapon : MonoBehaviour
{
    [SerializeField] WeaponsSO WeaponsSO;
    const string Shoot_String = "fire";
    float timesincelastshot = 0;
    Animator gunanimator;
    StarterAssetsInputs starterAssetsInputs;
    RaycastScript currentWeapon;
    void Awake()
    {
        starterAssetsInputs = GetComponentInParent<StarterAssetsInputs>();
    }
    void Start()
    {
        currentWeapon = GetComponentInChildren<RaycastScript>();
        gunanimator = GetComponent<Animator>();
    }
    void Update()
    {
        timesincelastshot += Time.deltaTime;
        handlefire();
    }
    public void switchweapon(WeaponsSO weaponsSO)
    {
        Debug.Log("Weapon switched to " + weaponsSO.name);
    }

    void handlefire()
    {
        if (!starterAssetsInputs.shoot) return;
        if (timesincelastshot >= WeaponsSO.fireRate)
        {
            currentWeapon.shoot(WeaponsSO);
            gunanimator.Play(Shoot_String, 0, 0f);
            timesincelastshot = 0;
        }

        if(!WeaponsSO.isAutomatic)
        {
            starterAssetsInputs.shoot = false;
        }

            

    }
}