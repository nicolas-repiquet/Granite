using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Granite.Core;
using Test.Game_01.Maps;

namespace Test.Game_01.Levels
{
    public abstract class Level
    {
        public Map Map { get; private set; }

        public Level()
        {
            var reader = new StreamReader(this.GetType().GetAssociatedResource("txt"));
            var lines = new List<string[]>();
            
            string line;
            int width = 0;

            while ((line = reader.ReadLine()) != null)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    var tokens = line.Split('|');
                    lines.Add(tokens);
                    width = Math.Max(width, tokens.Length);
                }
            }

            lines.Reverse();

            var mats = new Material[width, lines.Count];

            for (int y = 0; y < lines.Count; y++)
            {
                var l = lines[y];

                for (int x = 0; x < l.Length; x++)
                {
                    var desc = l[x];

                    if (desc == "GR")
                    {
                        mats[x, y] = Grass.Instance;
                    }
                    else if (desc == "CA")
                    {
                        mats[x, y] = Castle.Instance;
                    }
                    else if (desc == "WA")
                    {
                        mats[x, y] = Water.Instance;
                    }
                    else if (desc == "LA")
                    {
                        mats[x, y] = Lava.Instance;
                    }
                }
            }

            Map = new Map(mats);
        }
    }
}
