using Godot;

namespace NJM.Business.Game.Internal {

    public partial class GameRoleEntity : Node {

        int id;
        public int ID => id;

        bool isOwner;
        public bool IsOwner => isOwner;

        public GameRoleEntity() {}

        public void Ctor(int id, bool isOwner) {
            this.id = id;
            this.isOwner = isOwner;
        }

    }

}