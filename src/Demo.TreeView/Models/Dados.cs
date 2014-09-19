using System.Linq;
using System.Collections.Generic;

namespace Demo.TreeView.Models
{
    public class Dados
    {
        private static IList<Gerente> gerentes;
        private static IList<Loja> lojas;

        static Dados()
        {
            gerentes = new List<Gerente>
            {
                new Gerente{ID=1,Nome="Fabiano Nalin"},
                new Gerente{ID=2,Nome="Priscila Mitui"},
                new Gerente{ID=3,Nome="Carlos da Silva"},
                new Gerente{ID=4,PaiID=1,Nome="Raphael Nalin"},
                new Gerente{ID=5,PaiID=1,Nome="Daniel Pereira"},
                new Gerente{ID=6,PaiID=4,Nome="Fernanda Franco"},
                new Gerente{ID=7, PaiID=2,Nome="Vinicius Rocha"},
                new Gerente{ID=8, PaiID=2,Nome="Murilo Santos"},
                new Gerente{ID=9, PaiID=8,Nome="Stephan da Silva"},
                new Gerente{ID=10, PaiID=3,Nome="Marcio Oliveira"},
            };

            lojas = new List<Loja> {
                new Loja{ID=1,Nome="Loja I",GerenteID=1},
                new Loja{ID=2,Nome="Loja II",GerenteID=2},
                new Loja{ID=3,Nome="Loja III",GerenteID=3},
                new Loja{ID=4,Nome="Loja IV",GerenteID=1},
                new Loja{ID=5,Nome="Loja V",GerenteID=4},
                new Loja{ID=6,Nome="Loja VI",GerenteID=5},
                new Loja{ID=7,Nome="Loja VII",GerenteID=1},
                new Loja{ID=8,Nome="Loja VIII",GerenteID=2},
                new Loja{ID=9,Nome="Loja IX",GerenteID=3},
                new Loja{ID=10,Nome="Loja X",GerenteID=4},
                new Loja{ID=11,Nome="Loja XI",GerenteID=5},
                new Loja{ID=12,Nome="Loja XII",GerenteID=6},
                new Loja{ID=13,Nome="Loja XIII",GerenteID=1},
                new Loja{ID=14,Nome="Loja XIV",GerenteID=7},
                new Loja{ID=15,Nome="Loja XV",GerenteID=8},
                new Loja{ID=16,Nome="Loja XVI",GerenteID=9},
                new Loja{ID=17,Nome="Loja XVII",GerenteID=10},
                new Loja{ID=18,Nome="Loja XVIII",GerenteID=1},
                new Loja{ID=19,Nome="Loja XIX",GerenteID=2},
                new Loja{ID=20,Nome="Loja XX",GerenteID=4},
            };
        }

        public static IList<Gerente> GetGerentes { get { return gerentes; } }
        public static IList<Loja> GetLojas(int[] gerentes) { return lojas.Where(d=> gerentes.Contains(d.GerenteID)).ToList(); }

    }
    public class Gerente
    {
        public int ID { get; set; }
        public int? PaiID { get; set; }
        public string Nome { get; set; }
    }

    public class Loja
    {
        public int ID { get; set; }
        public int GerenteID { get; set; }
        public string Nome { get; set; }
    }
}