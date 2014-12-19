using Granite.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Granite.Render
{
    public sealed class SpriteSheet
    {
        private readonly Dictionary<string, Sprite> m_sprites = new Dictionary<string, Sprite>();
        public Texture2D Texture { get; private set; }

        public SpriteSheet(Texture2D texture)
        {
            Texture = texture;
        }

        public SpriteSheet()
        {
            Texture = Texture2D.Load(this.GetType().GetAssociatedResource("png"));

            using (var reader = new StreamReader(this.GetType().GetAssociatedResource("txt")))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        var tokens = line.Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        if (tokens != null && tokens.Length == 5)
                        {
                            var name = tokens[0];
                            var x = int.Parse(tokens[1]);
                            var y = int.Parse(tokens[2]);
                            var w = int.Parse(tokens[3]);
                            var h = int.Parse(tokens[4]);

                            var tw = (float)Texture.Size.X;
                            var th = (float)Texture.Size.Y;

                            m_sprites.Add(name, new Sprite(
                                this,
                                name,
                                new Vector2i(Math.Abs(w), Math.Abs(h)),
                                new Box2(
                                    x / tw,
                                    y / th,
                                    w / tw,
                                    h / th
                                )
                            ));
                        }
                        else
                        {
                            throw new Exception("Invalid line : " + line);
                        }
                    }
                }
            }
        }

        public Sprite GetSprite(string name)
        {
            Sprite sprite;
            if (m_sprites.TryGetValue(name, out sprite))
            {
                return sprite;
            }
            else
            {
                return null;
            }
        }

        public Sprite AddSprite(string name, Box2i coordinates)
        {
            var tw = (float)Texture.Size.X;
            var th = (float)Texture.Size.Y;

            var sprite = new Sprite(
                this,
                name,
                coordinates.Size,
                new Box2(
                    coordinates.Position.X / tw,
                    coordinates.Position.Y / th,
                    coordinates.Size.X / tw,
                    coordinates.Size.Y / th
            ));

            m_sprites.Add(sprite.Name, sprite);
            return sprite;
        }

        public IEnumerable<Sprite> Sprites { get { return m_sprites.Values; } }
    }
}
