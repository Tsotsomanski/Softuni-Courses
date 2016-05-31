using WindowsFormsApplication1.Paduins;

namespace WindowsFormsApplication1.Interface.IPadaun.IPaduinStudents
{
    public interface IPaduin
    {
        int PointKnowledge { get; }

        int PaduinPower { get; }

        int BeerPerSecond { set; }

        PaduinType PaduinType { get; }

        string CharacterImage { get; }

        void KnowledgeCalculator();
    }
}