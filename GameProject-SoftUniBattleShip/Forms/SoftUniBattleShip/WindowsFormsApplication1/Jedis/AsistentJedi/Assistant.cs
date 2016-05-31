using WindowsFormsApplication1.Interface;
using WindowsFormsApplication1.Interface.IJedi.IAssistants;

namespace WindowsFormsApplication1.Jedis.AsistentJedi
{
    public abstract class Assistant : IAssistants
    {
        protected int assistantAttack;
        protected int assistantLives;
        protected int assistantPoints;

        protected Assistant()
        {
        }

        public abstract int AssistantPoint { get; set; }

        public abstract int AssistantAttack { get; set; }

        public abstract int AssistantLive { get; set; }

        public abstract string CharacterImage { get; set; }

        public abstract AssistantJediType AssistantJediType { get; set; }

        public virtual void Point()
        {
            throw new System.NotImplementedException();
        }
    }
}