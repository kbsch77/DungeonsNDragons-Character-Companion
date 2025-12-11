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

        public CharacterModel(Character character) 
        { 
            _name = character.GetName();
            _class = character.GetClass();
            _background = character.GetBackground();
            _level = character.GetLevel();

            _strength = character.GetStrength();
            _dexterity = character.GetDexterity();
            _constitution = character.GetConstitution();
            _intelligence = character.GetIntelligence();
            _wisdom = character.GetWisdom();
            _charisma = character.GetCharisma();

            _strengthSave = character._strengthSave;
            _dexteritySave = character._dexteritySave;
            _constitutionSave = character._constitutionSave;
            _intelligenceSave = character._intelligenceSave;
            _wisdomSave = character._wisdomSave;
            _charismaSave = character._charismaSave;

            _athletics=character._athletics;
            _acrobatics=character._acrobatics;
            _sleightOfHand=character._sleightOfHand;
            _stealth=character._stealth;
            _arcana=character._arcana;
            _history=character._history;
            _investigation=character._investigation;
            _nature=character._nature;
            _religion=character._religion;
            _animalHandling=character._animalHandling;
            _insight=character._insight;
            _medicine=character._medicine;
            _perception=character._perception;
            _survival=character._survival;
            _deception=character._deception;
            _intimidation=character._intimidation;
            _performance=character._performance;
            _persuasion=character._persuasion;
        }
    }
}
