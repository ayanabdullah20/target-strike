using UnityEngine;

public class weaponpickup : MonoBehaviour
{
    [SerializeField] WeaponsSO weaponSO;
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            ActiveWeapon activeWeapon = other.GetComponentInChildren<ActiveWeapon>();
            activeWeapon.switchweapon(weaponSO);
    }
}
}