﻿using System;
using System.Text;

namespace Roguelike {
    public class Program {
        static void Main(string[] args) {
            // Utiliza o UTF-8 na consola
            Console.OutputEncoding = Encoding.UTF8;
            Console.SetWindowSize(Console.LargestWindowWidth,
                Console.LargestWindowHeight);
            // Construtor vazio
            Menu menu = new Menu();

            menu.Options();
        }
    }
}
