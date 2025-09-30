using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HelpperRPG.Core.Entities
{
    public class Character
    {
        // PARAMS
        // Information
        public int Id { get; init; } // 'init' só permite setar no construtor;
        public string Name { get; set; }
        public int Level { get; set; }
        public CharClass CharacterClass { get; set; }
        public Race CharacterRace { get; set; }

        // Health & CA
        public int MaxHealth { get; private set; }
        public int Health { get; private set; }
        public int Ca { get; set; }

        // Atributes
        public int Str { get; private set; } // Strenght
        public int Dex { get; private set; } // Dexterity
        public int Con { get; private set; } // Constitution 
        public int Wis { get; private set; } // Wisdom
        public int Cha { get; private set; } // Charism
        public int Kno { get; private set; } // Knowledge ( Inteligence )

        // Capabilities
        public List<Skill> CharacterSkills { get; set; } = new List<Skill>();
        public List<Perk> CharacterPerks { get; set; } = new List<Perk>();
        public List<Effect> CharacterEffects { get; set; } = new List<Effect>();
        public List<Item> Inventory { get; set; } = new List<Item>();
        public List<String> Proefficiencies { get; set; } = new List<String>

        // ---------- ACTIONS ----------
        public Character newCharacter()
        {
            // Faz toda a criação de um personagem;
        }





    }
}
