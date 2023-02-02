using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace OverrideMetodoToString
{
    public class Objeto
    {
        public string Name { get; set; }
        public string Idade { get; set; }
        public int Classificacao { get; set; }

        ////Se aceitar o default, a saida será default
        //public override string ToString()
        //{
        //    return base.ToString();
        //}

        //Pre formatando
        public override string ToString()
        {
            return $"Nome de usuário: {this.Name} | Pontos: {this.Classificacao}";
        }
    }
}
