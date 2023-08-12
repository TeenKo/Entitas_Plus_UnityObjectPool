using System;
using _Core_.Common;
using Entitas;
using UnityEngine;

namespace _Core_.Level
{
    public class LevelView : MonobehAdvGame
    {
        [SerializeField] private NavigationAreaView[] navigationAreaViews;
        public override void Link(IEntity entity)
        {
            base.Link(entity);
            GameEntity.isLevel = true;

            foreach (var navigationAreaView in navigationAreaViews)
            {
                var gameEntity = Contexts.sharedInstance.game.CreateEntity();
                gameEntity.AddIndex(Array.IndexOf(navigationAreaViews, navigationAreaView));
                navigationAreaView.Link(gameEntity);
            }
        }
    }
}
