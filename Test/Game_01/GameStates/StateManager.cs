using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Game_01.GameStates
{
    public enum EGameState
    {
        MAINMENU,
        GAME,
        EDITOR,
        PAUSE
    }

    public class StateManager
    {
        private static StateManager m_instance;
        public static StateManager Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new StateManager();
                }

                return m_instance;
            }
        }

        private EGameState? m_gameState;
        private Dictionary<EGameState, IGameState> m_gameStates;

        public StateManager()
        {
            m_gameStates = new Dictionary<EGameState, IGameState>();

            SetGameState(EGameState.MAINMENU);
        }

        public void SetGameState(EGameState gameState)
        {
            if (m_gameState.HasValue)
            {
                m_gameStates[m_gameState.Value].Cleanup();
            }

            bool stateHasChanged = false;
            
            switch (gameState)
            {
                case EGameState.MAINMENU:
                    if (!m_gameState.HasValue 
                        || m_gameState.Value == EGameState.PAUSE)
                    {
                        m_gameStates.Clear();
                        m_gameStates[gameState] = new MainMenuState();

                        stateHasChanged = true;
                    }
                    break;
                case EGameState.GAME:
                    if (m_gameState.HasValue 
                        && (m_gameState.Value == EGameState.MAINMENU
                        || m_gameState.Value == EGameState.PAUSE))
                    {
                        if (m_gameState.Value == EGameState.MAINMENU)
                        {
                            m_gameStates[gameState] = new GameState();
                            m_gameStates[gameState].Init();
                        }
                        else if (m_gameState.Value == EGameState.PAUSE)
                        {
                            m_gameStates[gameState].Resume();
                        }

                        stateHasChanged = true;
                    }
                    break;
                case EGameState.EDITOR:
                    if (m_gameState.HasValue 
                        && (m_gameState.Value == EGameState.MAINMENU
                        || m_gameState.Value == EGameState.PAUSE))
                    {
                        if (!m_gameStates.ContainsKey(gameState))
                        {
                            m_gameStates[gameState] = new EditorState();
                        }

                        stateHasChanged = true;
                    }
                    break;
                case EGameState.PAUSE:
                    if (m_gameState.HasValue 
                        && (m_gameState.Value == EGameState.GAME
                        || m_gameState.Value == EGameState.EDITOR))
                    {
                        m_gameStates[m_gameState.Value].Pause();

                        m_gameStates[gameState] = new PauseState();
                        m_gameStates[gameState].Init();

                        stateHasChanged = true;
                    }
                    break;
            }


            if (stateHasChanged)
            {
                Console.WriteLine(
                    string.Format("L'état du jeu a été modifié ! ({0} => {1})",
                    m_gameState, gameState));

                this.m_gameState = gameState;
            }
            else
            {
                Console.WriteLine(
                    string.Format("L'état du jeu n'a pas pu être modifié ! ({0} => {1})",
                    m_gameState, gameState));
            }
        }

        public void Update(TimeSpan elapsed)
        {
            if (m_gameState.HasValue)
            {
                m_gameStates[m_gameState.Value].Update(elapsed);
            }
        }

        public void Draw()
        {
            if (m_gameState.HasValue)
            {
                m_gameStates[m_gameState.Value].Draw();
            }
        }
    }
}
