using System;
using System.Collections.Generic;
using Entitas;

namespace Game.SceneLoad
{
    public class InitFromSceneSystem : IExecuteSystem
    {
        private static readonly Queue<List<IComponent>> InitQueue = new Queue<List<IComponent>>();
        
        private readonly GameContext _gameContext;

        public static void AddToInitQueue(List<IComponent> entityInitList)
        {
            InitQueue.Enqueue(entityInitList);
        }
        
        
        public InitFromSceneSystem(Contexts contexts)
        {
            _gameContext = contexts.game;
        }
        
        
        public void Execute()
        {
            while (InitQueue.Count > 0)
            {
                var initList = InitQueue.Dequeue();
                var entity = _gameContext.CreateEntity();
                foreach (var component in initList)
                {
                    int index = Array.IndexOf(GameComponentsLookup.componentTypes, component.GetType());
                    entity.AddComponent(index, component);
                }
            }
        }
    }
}