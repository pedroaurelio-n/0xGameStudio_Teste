using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
namespace PedroAurelio
{
    [CreateAssetMenu(fileName = "New Shooting Pattern", menuName = "Shooting Pattern")]
    public class ShootingPattern : ScriptableObject
    {
        [Header("Dependencies")]
        public Bullet BulletPrefab;

        [Header("Spawn Settings")]
        public float StartDelay;
        public float SpinRate;
        public int SideCount;
        [Range(0f, 360f)] public float AngleOpening;
        [Range(0f, 360f)] public float AngleOffset;

        [Header("Accuracy Settings")]
        [Range(0f, 1f)] public float MissRate;
        [Range(0f, 360f)] public float MissAngleOpening;

        [Header("Shot Settings")]
        public bool NeedInput;
        public bool IsAiming;
        public float BulletSpeed;
        public float FireRate;
    }
}