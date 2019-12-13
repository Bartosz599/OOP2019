using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    enum charClass { warrior, mage, archer}
    enum classDamage { pół, półtorej, jeden }
    class character
    {
        
        public int hp;
        public double posx;
        public double posy;
        public int lvl;
        public string nick;
        public charClass klasa;

        private character()
        {

        }
        private character(double posx, double posy, int lvl, string nick, charClass klasa, int hp)
        {
            this.hp=hp;
            this.posx = posx;
            this.posy = posy;
            this.lvl = lvl;
            this.nick = nick;
            this.klasa = klasa;

        }
        public static character Generate(double posx, double posy, int lvl, string nick, charClass klasa, int hp)
        {
            return new character(posx, posy, lvl, nick, klasa, hp);
        }
        

        public void DMGcalc()
        {
            double damage;
            switch()
            {
                case classDamage.pół:
                    damage=this.lvl-
                    break;
                    (




            }
        }

    }
}
