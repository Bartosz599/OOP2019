using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRARPG
{

    abstract class Hero
    {
        public int hp;
        public int hp_max;
        public int def;
        public int lvl;
        public int exp;
        public int lvl_next;
        public int gold;
        public string name;
        
       
    }
    class Mag:Hero
    {
        public int Int;
        public int mp;
        public int mp_max;
        public void atack()
        {

        }
        public Mag(int Int, int hp, int hp_max, int def, int lvl, int exp, int lvl_next, int gold, string name, int mp, int mp_max)
        {
            this.Int = Int;
            this.hp = hp;
            this.hp_max = hp_max;
            this.def = def;
            this.lvl = lvl;
            this.lvl_next = lvl_next;
            this.exp = exp;
            this.gold = gold;
            this.name = name;
            this.mp = mp;
            this.mp_max = mp_max;

        }
        public static Mag Generate(int Int, int hp, int hp_max, int def, int lvl, int exp, int lvl_next, int gold, string name, int mp, int mp_max)

        {

            return new Mag(Int, hp, hp_max, def, lvl, exp, lvl_next, gold, name, mp, mp_max);

        }

    }
    class Wojownik:Hero
    {
        public int str;
        public int rage;
        public int rage_max;
        public Wojownik(int str, int hp, int hp_max, int def, int lvl, int exp, int lvl_next, int gold, string name, int rage, int rage_max)
        {
            this.str = str;
            this.hp = hp;
            this.hp_max = hp_max;
            this.def = def;
            this.lvl = lvl;
            this.lvl_next = lvl_next;
            this.exp = exp;
            this.gold = gold;
            this.name = name;
            this.rage = rage;
            this.rage_max = rage_max;

        }
        public static Wojownik lvlup(int lvl, int lvl_next, int gold, int exp, string name, int newhp, int neweng, int newdps, int newdef)
        {
            int lvlnew = lvl+1;
            int lvl_nextnew = lvl_next * 2;
            return new Wojownik(newdps, newhp, newhp, newdef, lvlnew, exp, lvl_nextnew, gold, name, neweng, neweng);
        }
    }
    class Lotrzyk:Hero
    {
        public int dex;
        public int sp;
        public int sp_max;
        public Lotrzyk(int dex, int hp, int hp_max, int def, int lvl, int exp, int lvl_next, int gold, string name, int sp, int sp_max)
        {
            this.dex = dex;
            this.hp = hp;
            this.hp_max = hp_max;
            this.def = def;
            this.lvl = lvl;
            this.lvl_next = lvl_next;
            this.exp = exp;
            this.gold = gold;
            this.name = name;
            this.sp = sp;
            this.sp_max = sp_max;

        }
        public static Lotrzyk Generate(int dex, int hp, int hp_max, int def, int lvl, int exp, int lvl_next, int gold, string name, int sp, int sp_max)

        {

            return new Lotrzyk(dex, hp, hp_max, def, lvl, exp, lvl_next, gold, name, sp, sp_max);

        }

    }
        
}
