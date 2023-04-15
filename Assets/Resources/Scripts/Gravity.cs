using UnityEngine;

namespace Resources.Scripts
{
    public class Gravity : MonoBehaviour
    {
        [SerializeField]
        private Level4 _player;

        private void Awake()
        {
            var rigidbody = _player.GetComponent<Rigidbody>();
            rigidbody.useGravity = _player.UseGravity;
        }
    }
}