﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    internal class Player : Actor
    {
        int health;

        public Player(Texture2D texture, Vector2 position) : base(texture, position)
        {
            sourceRectangle = new Rectangle(0, 0, Tile.tileSize, Tile.tileSize);
        }
    }
}