namespace WindowsFormsApplication1.Interface.IJedi.IAssistants
{
    public interface IAssistants
    {
        int AssistantPoint { get; } // Damage който му се нанася

        int AssistantAttack { get; } //Damage който нанася 

        int AssistantLive { get; } // Живота му

        AssistantJediType AssistantJediType { get; }

        string CharacterImage { get; }

        void Point();
    }
}