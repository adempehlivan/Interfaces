using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICharacter
    {
        RACE_TYPE Race { get; set; }
        RACE_CLASS_TYPE RaceClass { get; set; }
        string CharName { get; set; }
        RACE_SIDE AlliedRace { get; set; }
        RACE_SIDE EnemyRaces { get; set; }
        int Hp { get; set; }
        int AttackPower { get; set; }
    }

    

    public enum RACE_TYPE
    {
        ELF, ORC,
        HUMAN, GOBLIN
    }

    public enum RACE_CLASS_TYPE
    {
        WARRIOR, DEATH_KNIGHT,
        PRIEST, PALADIN
    }

    public enum RACE_SIDE
    {
       HORDE, ALLIANCE
    }


}
