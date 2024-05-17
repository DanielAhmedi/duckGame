using DuckGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuckGame.Control
{
   

public class GameController
    {
        private Player player;
        private List<Enemy> enemies;
        private GameLogic gameLogic;

        public GameController(Player player, List<Enemy> enemies)
        {
            this.player = player;
            this.enemies = enemies;
            this.gameLogic = new GameLogic(player, enemies);
        }

        public void HandleKeyPress(Keys key)
        {
            // Обработка нажатия клавиш пользователем
            switch (key)
            {
                case Keys.Up:
                case Keys.W:
                    player.Move(0, -10); // Движение вверх
                    break;
                case Keys.Down:
                case Keys.S:
                    player.Move(0, 10); // Движение вниз
                    break;
                case Keys.Left:
                case Keys.A:
                    player.Move(-10, 0); // Движение влево
                    break;
                case Keys.Right:
                case Keys.D:
                    player.Move(10, 0); // Движение вправо
                    break;
            }
        }

        public void UpdateGame()
        {
            gameLogic.UpdateGame();
        }
    

}
}
