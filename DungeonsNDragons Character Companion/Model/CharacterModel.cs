using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsNDragons_Character_Companion.Model
{
    internal class CharacterModel
    {
        //basic character info
        public string _name = "";
        public string _class = "";
        public string _background = "";
        public int _level = 1;

        //base stats
        public int _strength;//str
        public int _dexterity;//dex
        public int _constitution;//con
        public int _intelligence;//int
        public int _wisdom;//wis
        public int _charisma;//cha

        //saving throws
        public int _strengthSave;
        public int _dexteritySave;
        public int _constitutionSave;
        public int _intelligenceSave;
        public int _wisdomSave;
        public int _charismaSave;

        //str
        public int _athletics;
        //dex
        public int _acrobatics;
        public int _sleightOfHand;
        public int _stealth;
        //int
        public int _arcana;
        public int _history;
        public int _investigation;
        public int _nature;
        public int _religion;
        //wis
        public int _animalHandling;
        public int _insight;
        public int _medicine;
        public int _perception;
        public int _survival;
        //cha
        public int _deception;
        public int _intimidation;
        public int _performance;
        public int _persuasion;
    }
}
