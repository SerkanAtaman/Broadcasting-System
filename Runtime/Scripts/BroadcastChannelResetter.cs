using UnityEngine;

namespace SeroJob.BroadcastingSystem
{
    public class BroadcastChannelResetter : MonoBehaviour
    {
        [SerializeField]
        private ResetTime _resetTime = ResetTime.Destroy;

        [SerializeField]
        private BroadcastChannel[] _channels;

        private void Awake()
        {
            if (_resetTime != ResetTime.Awake) return;

            ResetChannels();
        }

        private void Start()
        {
            if (_resetTime != ResetTime.Start) return;

            ResetChannels();
        }

        private void OnDisable()
        {
            if (_resetTime != ResetTime.Disable) return;

            ResetChannels();
        }

        private void OnDestroy()
        {
            if (_resetTime != ResetTime.Destroy) return;

            ResetChannels();
        }

        public void ResetChannels()
        {
            foreach (var channel in _channels)
            {
                channel.RemoveAllListeners();
            }
        }
    }

    public enum ResetTime
    {
        Awake,
        Start,
        Disable,
        Destroy,
        Manuel
    }
}