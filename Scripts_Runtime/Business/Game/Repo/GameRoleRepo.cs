using System.Collections.Generic;
using Godot;

namespace NJM.Business.Game.Internal {

    public class GameRoleRepo {

        Dictionary<int, GameRoleEntity> all;

        GameRoleEntity owner;
        public GameRoleEntity Owner => owner;

        public GameRoleRepo() {
            this.all = new Dictionary<int, GameRoleEntity>();
        }

        public void Add(GameRoleEntity entity) {
            all.Add(entity.ID, entity);
            if (entity.IsOwner) {
                if (owner == null) {
                    owner = entity;
                } else {
                    PLog.Error("replace owner");
                }
            }
        }

        public bool TryGet(int id, out GameRoleEntity entity) {
            return all.TryGetValue(id, out entity);
        }

    }

}