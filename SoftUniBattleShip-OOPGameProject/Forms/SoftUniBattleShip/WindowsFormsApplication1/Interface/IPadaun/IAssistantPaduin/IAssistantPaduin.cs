namespace WindowsFormsApplication1.Interface.IPadaun.IAssistantPaduin
{
    public interface IAssistantPaduin
    {

        int AssistantPoint { get; } // Damage който му се нанася

        int AssistantAttack { get; } //Damage който нанася 

        int AssistantLive { get; } // Живота му

        AssistantPaduinType AssistantPaduinType { get; set; }

        void Point();

    }
}