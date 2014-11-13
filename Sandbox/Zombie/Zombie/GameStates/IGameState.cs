﻿using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.GameStates
{
    public interface IGameState
    {
        void Init();
        void Cleanup();

        void Pause();
        void Resume();

        void Update(TimeSpan elapsed);
        void Draw();
    }
}
