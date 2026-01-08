using UnityEngine;

[CreateAssetMenu(fileName = "WeaponSO", menuName = "ScriptableObjects/WeaponsSO")]
public class WeaponsSO : ScriptableObject
{
    public GameObject weaponprefab;
    public int damageAmount = 1;
    public float fireRate = 0.5f;

    public GameObject hitvfxpreefab;
    public bool isAutomatic = false;

}
