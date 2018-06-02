﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike {
    public class GameManager {
        public void Update() {
            World world = new World();
            Interface visualization = new Interface();
            LevelGenerator levelGen = new LevelGenerator();
            int oldLevel = 1, currentLevel = 1;

            visualization.ShowWorld(world);
            visualization.ShowStats(world);

            Console.ReadKey();
        }
    }
}
