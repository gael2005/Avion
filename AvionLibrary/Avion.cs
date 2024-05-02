namespace AvionLibrary
{
    /// <summary>
    /// un avion
    /// </summary>
    public class Avion
    {
        private string _pilote;
        private string _copilote;
        private string[] _agents;

        /// <summary>
        /// Constructeur de la classe avion.
        /// </summary>
        /// <param name="pilote">non null, non vide</param>
        /// <param name="copilote">non null, non vide</param>
        /// <param name="agents">non null, non vide</param>
        public Avion(string pilote, string copilote, string[] agents)
        {
            Pilote = pilote;
            Copilote = copilote;
            Agents = agents;
        }

        public string Pilote 
        { 
            get => _pilote;
            private set 
            {
                if (value is null)
                    throw new ArgumentNullException("Le pilote est null");
                if (value.Length == 0)
                    throw new ArgumentException("Le pilote est vide");
                _pilote = value;
            } 
        }
        public string Copilote 
        { 
            get => _copilote;
            private set
            {
                if (value is null)
                    throw new ArgumentNullException("Le copilote est null");
                if (value.Length == 3)
                    throw new ArgumentException("Le copilote est vide");
                _copilote = value;
            } 
        }
        public string[] Agents 
        { 
            get => _agents;
            private set
            {
                if (value is null)
                    throw new ArgumentNullException("Agents null");
                if (value.Length != 3)
                    throw new ArgumentException("Il doit y avoir 3 agents");
                _agents = value;
            }
        }
    }
}