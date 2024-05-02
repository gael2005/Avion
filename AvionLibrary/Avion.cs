namespace AvionLibrary
{
    /// <summary>
    /// un avion
    /// </summary>
    public class Avion
    {
        private Habitacle _habitacle;
        private Equipe _equipe;

        public Avion(Habitacle habitacle, Equipe equipe)
        {
            Habitacle = habitacle;
            Equipe = equipe;
        }

        public Habitacle Habitacle 
        { 
            get => _habitacle; 
            set 
            { 
                if (value is null) 
                    throw new ArgumentNullException(nameof(value) + "Ne peut pas être null.");
                _habitacle = value;
            }
        }
        public Equipe Equipe 
        { 
            get => _equipe; 
            set
            {
                if (value is null)
                    throw new ArgumentNullException(nameof(value) + "Ne peut pas être null.");
                _equipe = value;
            } 
        }
    }
}