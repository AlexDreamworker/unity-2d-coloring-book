using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace ChildPaint.Components
{
	public class RandomSoundComponent : MonoBehaviour
	{
		[SerializeField] private AudioSource _source;
		[SerializeField] private AudioGroup[] _groupClips;

		private AudioGroup _currentGroup;

		public void Play(string groupName) 
		{
			for (var i = 0; i < _groupClips.Length; i++) 
			{
				if (_groupClips[i].Name == groupName)
				{
					_currentGroup = _groupClips[i];
					var currentClip = _currentGroup.Clips[Random.Range(0, _currentGroup.Clips.Length)];

					_source.PlayOneShot(currentClip);
				}
			}
		}
	}

	[Serializable]
	public class AudioGroup 
	{
		[SerializeField] private string _name;
		[SerializeField] private AudioClip[] _clips;

		public string Name => _name;
		public AudioClip[] Clips => _clips;
	}
}

