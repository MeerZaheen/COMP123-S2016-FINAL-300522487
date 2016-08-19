using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2016_FinalExam
{
    public class Character
    {
        //***** PRIVATE INSTANCE VARIABLES *****//
        string _firstName, _lastName;
        int _strength, _dexterity, _constitution, _intelligence, _wisdom, _charisma;

        //****** PUBLIC PROPERTIES *****//
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

    }
}