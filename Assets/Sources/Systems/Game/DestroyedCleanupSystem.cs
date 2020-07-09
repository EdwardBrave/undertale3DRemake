﻿using System.Collections.Generic;
using Entitas;
using Entitas.Unity;
using Entitas.VisualDebugging.Unity;

namespace Systems.Game
{
    public class DestroyedCleanupSystem: ICleanupSystem
    {
        private readonly IGroup<GameEntity> _destroyedEntities;
        
        private readonly List<GameEntity> _buffer;
        
        public DestroyedCleanupSystem(Contexts contexts)
        {
            _destroyedEntities = contexts.game.GetGroup(GameMatcher.Destroyed);
            
            _buffer = new List<GameEntity>();
        }
        
        public void Cleanup()
        {
            foreach (var entity in _destroyedEntities.GetEntities(_buffer))
            {
                if (entity.hasView)
                {
                    entity.view.obj.Unlink();
                    entity.view.obj.DestroyGameObject();
                }
                entity.Destroy();
            }
        }
    }
}