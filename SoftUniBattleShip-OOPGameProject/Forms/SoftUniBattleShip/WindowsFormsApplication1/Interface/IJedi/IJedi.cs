namespace WindowsFormsApplication1.Interface.IJedi
{
    public interface IJedi
    {
        int PointsDamage { get; set; } 

        int KnowledgeDamage { get; set; }

        int ThePolerOfDrinks { get; set; } 

        JediType JediType { get; set; } 

        string CharacterImage { get; set; }

        void Points();
    }
}