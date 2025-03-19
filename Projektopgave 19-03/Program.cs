using System.Diagnostics.CodeAnalysis;
using static Projektopgave_19_03.ToejStykke;

namespace Projektopgave_19_03
{
    internal class GreenKids
    {
        static void Main(string[] args)
        {
            ToejStykke Troeje = new(1, "Troeje", "Large", "Adidas", "Bomuld", false, ToejTilstand.God, DateTime.Now, 90);
            ToejStykke Hoodie = new ToejStykke(45, "Hoodie", "L", "Nike", "Polyester", false, ToejTilstand.Middel, DateTime.Now, 45);


            Console.WriteLine(Troeje.Maerke);
            Console.WriteLine(Hoodie.Maerke);

        }
    }

    public class ToejStykke
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Stoerrelse { get; set; }
        public string Maerke { get; set; }
        public string Materiale { get; set; }
        public bool ErSolgt { get; set; }
        public double Miljoegevinst { get; set; }
        public DateTime Indleveringsdato { get; set; }
        public ToejTilstand Stand { get; set; }

        public ToejStykke(int id, string type, string stoerrelse, string maerke, string materiale, bool ersolgt, ToejTilstand stand, DateTime indleveringsDato, double miljoeGevinst)
        {
            Id = id;
            Type = type;
            Stoerrelse = stoerrelse;
            Maerke = maerke;
            Materiale = materiale;
            ErSolgt = ersolgt;
            ToejTilstand Stand = stand;
            Indleveringsdato = indleveringsDato;
            Miljoegevinst = miljoeGevinst;

        }

        public static List<ToejStykke> toejStykker = [];

        public static string[] toejTyper = { "Jakke", "Hoodie", "T-Shirt", "Bukser", "Sko", "Diverse" };


        public static Dictionary<string, double> MiljøGevinst = new()
        {
            {"Bomuld", 51.99   },
            {"Polyester",100.99 },
            {"Viskose", 43.22 },
            { "Hør", 14.99},
            {"Uld", 9.32 },
            {"Nylon", 17.47 },
            {"Silke", 2.33},
            {"Elasthan", 53.77 }
        };

        public static void Tilfoej(ToejStykke Tøj)
        {
           toejStykker.Add(Tøj);
        }

    }
    public enum ToejTilstand
    {
        God,
        Middel,
        Slidt
    }



}
