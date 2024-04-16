using UnityEngine;
using YG;

namespace Ilumisoft.Game
{
    public class HighscoreSystem : MonoBehaviour, IHighscoreSystem
    {
        private const string PlayerPrefsKey = "Highscore";

        private float _highscore = 0;

        public float Highscore
        {
            get => YandexGame.savesData.MaxScore;
            set
            {
                _highscore = value;
                SaveHighscore();
            }
        }

        private void Awake()
        {
            LoadHighscore();
        }

        private void LoadHighscore()
        {
            _highscore = YandexGame.savesData.MaxScore;
        }

        private void SaveHighscore()
        {
            YandexGame.savesData.MaxScore = _highscore;
            YandexGame.SaveProgress();
        }
    }
}