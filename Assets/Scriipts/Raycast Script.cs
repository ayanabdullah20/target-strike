using StarterAssets;
using Unity.Mathematics;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{
    [SerializeField] ParticleSystem muzzleFlash;


    public void shoot(WeaponsSO weaponsSO)
    {
         muzzleFlash.Play();
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity))
        {
   
            Instantiate(weaponsSO.hitvfxpreefab, hit.point, quaternion.identity);
            EnemyHealth enemyHealth = hit.collider.GetComponent<EnemyHealth>();
            enemyHealth?.TakeDamage(weaponsSO.damageAmount);

        }
    }
}
