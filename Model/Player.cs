using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DuckGame.Model
{

    public class Player
    {
            public int Top { get; set; }
            public int Left { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public Rectangle Bounds => new Rectangle(Left, Top, Width, Height);

            public void Move(int deltaX, int deltaY)
            {
                Left += deltaX;
                Top += deltaY;
            }
    }

        public class Enemy
        {
            public int Top { get; set; }
            public int Left { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public Rectangle Bounds => new Rectangle(Left, Top, Width, Height);

            public void Move(int deltaX)
            {
                Left += deltaX;
            }
        }

        public class GameLogic
        {
            private Player player;
            private List<Enemy> enemies;

            public GameLogic(Player player, List<Enemy> enemies)
            {
                this.player = player;
                this.enemies = enemies;
            }

            public void UpdateGame()
            {
                MovePlayer();
                MoveEnemies();
                CheckCollisions();
            }

            private void MovePlayer()
            {
                // Логика движения игрока
                // Например, движение в зависимости от нажатых клавиш
            }

            private void MoveEnemies()
            {
                // Логика движения врагов
                foreach (var enemy in enemies)
                {
                    enemy.Move(7); // Предположим, что враги двигаются вправо на 7 пикселей за обновление
                }
            }

            private void CheckCollisions()
            {
                // Проверка коллизий между игроком и врагами
                foreach (var enemy in enemies)
                {
                    if (player.Bounds.IntersectsWith(enemy.Bounds))
                    {
                        // Обработка столкновения (например, завершение игры или уменьшение здоровья игрока)
                        // Здесь можно добавить необходимую логику
                    }
                }
            }
        }

}
