/// <summary>
/// Classes métier
/// </summary>
namespace Mediatek86.metier
{
    /// <summary>
    /// Classe métier représentant un service dont peut dépendre un utilisateur
    /// </summary>
    public class Service
    {
        private readonly int id;
        private readonly string libelle;

        public Service(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public int Id => id;
        public string Libelle => libelle;
    }
}
