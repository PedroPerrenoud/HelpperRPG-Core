using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpperRPG.Core.Models
{
    public class Character
    {
        // Params
        public int Id { get; init; } // 'init' só permite setar no construtor;
        public string Name { get; set; }
        public int Level { get; set; }
        public CharClass CharacterClass { get; set; }
        public Race CharacterRace { get; set; }

        public int MaxHealth { get; private set; }
        public int Health { get; private set; }
        public int Ca { get; set; }

        public List<Skill> CharacterSkills { get; set; } = new List<Skill>();
        public List<Perk> CharacterPerks { get; set; } = new List<Perk>();
        public List<Effect> CharacterEffects { get; set; } = new List<Effect>();
        public List<Item> Inventory { get; set; } = new List<Item>();



        
    }
}
