using UnityEngine;
using UnityEngine.UI;

namespace WebGame397
{
    public class GameOverController : MonoBehaviour
    {
        [SerializeField] private Button mainBtn;
        [SerializeField] private Button restartBtn;
        [SerializeField] private Button quitBtn;
        [SerializeField] private SceneController sceneController;

        private void Start()
        {
            mainBtn.onClick.AddListener(() => SceneController.Instance.ChangeScene("Menu"));
            restartBtn.onClick.AddListener(() => SceneController.Instance.ChangeScene("Gameplay"));
        }
    }
}
