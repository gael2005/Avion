using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvionLibrary
{
    internal class Equipe
    {
        private string _pilote;
        private string _copilote;
        private string _agent1;
        private string _agent2;
        private string _agent3;


        /// <summary>
        /// Constructeur de la classe avion.
        /// </summary>
        /// <param name="pilote">non null, non vide</param>
        /// <param name="copilote">non null, non vide</param>
        /// <param name="agent1">non null, non vide</param>
        /// <param name="agent2">non null, non vide</param>
        /// <param name="agent3">non null, non vide</param>
        /// 
        public Equipe(string pilote, string copilote, string agent1, string agent2, string agent3)
        {
            Pilote = pilote;
            Copilote = copilote;
            Agent1 = agent1;
            Agent2 = agent2;
            Agent3 = agent3;

        }

        /// <summary>
        /// Vérification pour le Pilote
        /// </summary>
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

        /// <summary>
        /// Vérification pour le Copilote
        /// </summary>
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

        /// <summary>
        /// Vérification pour l'agent 1
        /// </summary>
        public string Agent1
        {
            get => _agent1;
            private set
            {
                if (value is null)
                    throw new ArgumentNullException("Agents null");
                if (value.Length != 3)
                    throw new ArgumentException("Il doit y avoir 3 agents");
                _agent1 = value;
            }
        }

        /// <summary>
        /// Vérification pour l'agent 2
        /// </summary>
        public string Agent2
        {
            get => _agent2;
            private set
            {
                if (value is null)
                    throw new ArgumentNullException("Agents null");
                if (value.Length != 3)
                    throw new ArgumentException("Il doit y avoir 3 agents");
                _agent2 = value;
            }
        }

        /// <summary>
        /// Vérification pour l'agent 3
        /// </summary>
        public string Agent3
        {
            get => _agent3;
            private set
            {
                if (value is null)
                    throw new ArgumentNullException("Agents null");
                if (value.Length != 3)
                    throw new ArgumentException("Il doit y avoir 3 agents");
                _agent3 = value;
            }
        }
    }
}
