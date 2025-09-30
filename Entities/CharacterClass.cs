using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpperRPG.Core.Entities
{
    public class CharacterClass
    {
        // PARAMS
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }

        // Dados
        public int DiceLife { get; set; }

        // Habilities, Perks and Proefficiencies
        public List<Skill> ClassSkills { get; set; } = new List<Skill>();
        public List<Perks> ClassPerks { get; set; } = new List<Perks>();
        public List<String> ClassProficiency { get; set; } = new List<String>

       /*
        * Quanto as habilidades espec�ficas de cada classe, talvez fosse 
        * melhor desenvolv�-las em uma classe de habilidades. Assim mante-
        * riamos uma �nica classe respons�vel por controlar as habilidades
        * e caberia � classe puxar essa habilidade espec�fica de todas as
        * habilidades criadas. 
        * 
        * Dessa forma:
        * conjuracao = new Skill()
        * E magos, feiticeiros e bruxos poderiam puxar essa magia de conjura��o.
        */

    }
}