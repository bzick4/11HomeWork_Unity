using UnityEngine;

public class FollowParticle : MonoBehaviour

{
    public Transform player;  // Цель, игрок
    public float distanceBehind = 2f;  // Расстояние позади игрока
    public Vector3 offset;  // Дополнительное смещение (например, по высоте)

    private void Update()
    {
        if (player != null)
        {
            // Вычисляем позицию позади игрока (в направлении его спины)
            Vector3 behindPosition = player.position - player.forward * distanceBehind;
            
            // Обновляем позицию системы частиц, добавляя смещение
            transform.position = behindPosition + offset;
            
            // Система частиц смотрит в ту же сторону, что и игрок
            transform.rotation = player.rotation;
        }
    }

    
    
    
    
    // [SerializeField] private Transform playerTransform;
    // private Transform _transform;
    //
    // private void Start()
    // {
    //     _transform = transform;
    // }
    //
    // private void Update()
    // {
    //     _transform.position = playerTransform.position;
    // }

}
