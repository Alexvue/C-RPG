using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Hero
    {
        public string Name;
        private int birthYear;
        public int Age
        {
            get
            {
                return DateTime.Now.Year - birthYear;
            }
            set
            {
                if (value < 0)
                {
                    birthYear = DateTime.Now.Year;
                }else if (value > 100)
                {
                    birthYear = DateTime.Now.Year - 100;
                }
                else
                {
                    birthYear = DateTime.Now.Year - value;
                }
            }
        }
        private bool? gender;
        public string Gender
        {
            get
            {
                if (gender == true)
                {
                    return "Мужчинa";
                }
                else if (gender == false)
                {
                    return "Женщина";
                }
                else
                {
                    return "Ты вообще кто?";
                }
            }
            set
            {
                if (value == "Мужчина")
                {
                    gender = true;
                }else if (value == "Женщина")
                {
                    gender = false;
                }
                else
                {
                    gender = null;
                }
            }
        }
        private int lvl;
        public int LVL
        {
            get
            {
                return lvl;
            }
            set
            {
                if (value < 0)
                {
                    lvl = 0;
                }else if (value > 10)
                {
                    lvl = 10;
                }
                else
                {
                    lvl = value;
                }
            }
        }
        private int strength;
        public int Strength
        {
            get
            {
                return strength;
            }
            set
            {
                if (value < 0)
                {
                    strength = 0;
                }
                else if (value > 10)
                {
                    strength = 10;
                }
                else
                {
                    strength = value;
                }
            }
        }
        private int intellect;
        public int Intellect
        {
            get
            {
                return intellect;
            }
            set
            {
                if (value < 0)
                {
                    intellect = 0;
                }
                else if (value > 10)
                {
                    intellect = 10;
                }
                else
                {
                    intellect = value;
                }
            }
        }
    }
}