using Raylib_CsLo;
using static Raylib_CsLo.Raylib;

namespace TheAbyss
{
    class NPC : Entity
    {
        private int HP;
        private int maxHP;
        private int ID;

        public enum NPCID
        {

        }

        public NPC(Texture texture, string name, int x, int y, int HP, int ID) : base(texture, name, x, y)
        {
            this.HP = HP;
            maxHP = HP;
            this.ID = ID;
        }

        public override void Update()
        {
            //call the parent Update method, then add PreAI() to the update method.
            base.Update();
            PreAI();
        }

        public virtual void PreAI()
        {
            //set things before the AI happens
            AI();
        }
        public virtual void AI()
        {
            //happens after PreAI();
        }
    }
}
