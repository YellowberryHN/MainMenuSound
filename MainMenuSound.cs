using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MainMenuSound
{
	[KSPAddon(KSPAddon.Startup.MainMenu, true)]
	public class MainMenuSound : MonoBehaviour
	{
		public string StartSound = "MainMenuSound/Start";

		private void Start()
		{
			print("MainMenuSound: Game has started!");

			if (!GameDatabase.Instance.ExistsAudioClip(StartSound))
			{
				Debug.LogError("MainMenuSound: Audio file not found: " + StartSound);
				return;
			}

			var audio = gameObject.AddComponent<AudioSource>();
			audio.clip = GameDatabase.Instance.GetAudioClip(StartSound);
			audio.Play();
			audio.loop = false;
		}
	}
}
