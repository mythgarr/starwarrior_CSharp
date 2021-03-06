﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Artemis;
using StarWarrior.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StarWarrior.Primitives;
using Microsoft.Xna.Framework.Content;

namespace StarWarrior.Spatials
{
    static class PlayerShip
    {
        private static Texture2D ship = null;

        public static void Render(SpriteBatch spriteBatch, ContentManager contentManager, Transform transform)
        {
            if (ship == null)
            {
                ship = contentManager.Load<Texture2D>("player");
            }
            Rectangle rect = new Rectangle((int)transform.X, (int)transform.Y, ship.Width, ship.Height);
            spriteBatch.Draw(ship, rect, Color.White);
        }
    }
}
