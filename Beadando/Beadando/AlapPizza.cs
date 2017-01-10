using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando
{
    public abstract class AlapPizza
    {
        public abstract int ar { get; }
        public abstract int meret { get; }
        public abstract string info { get; }
    }

    #region 32-es méret
    public class AlapPizza32 : AlapPizza
    {
        public override int ar
        {
            get
            {
                return 500;
            }
        }
        public override int meret
        {
            get
            {
                return 32;
            }
        }
        public override string info
        {
            get
            {
                return "32 cm alap";
            }
        }
    }

    #endregion
    #region 45-ös méret
    public class AlapPizza45 : AlapPizza
    {
        public override int ar
        {
            get
            {
                return 650;
            }
        }
        public override int meret
        {
            get
            {
                return 45;
            }
        }
        public override string info
        {
            get
            {
                return "45 cm alap";
            }
        }
    }
    #endregion
    #region Dekorátorok
    public abstract class PizzaDecorator : AlapPizza
    {
        AlapPizza _p;

        public PizzaDecorator(AlapPizza p)
        {
            _p = p;
        }

        public override int ar
        {
            get
            {
                return _p.ar;
            }
        }
        public override int meret
        {
            get
            {
                return _p.meret;
            }
        }
        public override string info
        {
            get
            {
                return _p.info;
            }
        }
    }


    #region Sajt
    /// <summary>
    /// Sajt feltét
    /// </summary>
    public class Sajt : PizzaDecorator
    {
        public Sajt(AlapPizza p) : base(p) { }
        public int sajtára = 50;
        public override int ar
        {
            get
            {
                return base.ar + sajtára;
            }
        }
        public override int meret
        {
            get
            {
                return base.meret;
            }
        }
        public override string info
        {
            get
            {
                return base.info + "+sajt";
            }
        }
    }

    #endregion

    #region Sonka
    /// <summary>
    /// sonka feltét a pizzára
    /// </summary>
    public class Sonka : PizzaDecorator
    {
        public Sonka(AlapPizza p) : base(p) { }
        public int feltetar = 110;
        public override int ar
        {
            get
            {
                return base.ar + feltetar;
            }
        }
        public override int meret
        {
            get
            {
                return base.meret;
            }
        }
        public override string info
        {
            get
            {
                return base.info + " +sonka ";
            }
        }
    }
    #endregion

    #region Gomba
    /// <summary>
    /// gomba feltét a pizzára
    /// </summary>    
    public class Gomba : PizzaDecorator
    {
        public Gomba(AlapPizza p) : base(p) { }
        public override int ar
        {
            get
            {
                return base.ar + 90;
            }
        }
        public override int meret
        {
            get
            {
                return base.meret;
            }
        }
        public override string info
        {
            get
            {
                return base.info + " +gomba ";
            }
        }
    }
    #endregion

    #region Kukorica
    /// <summary>
    /// kukorica feltét
    /// </summary>
    public class Kukorica : PizzaDecorator
    {
        public override int ar
        {
            get
            {
                return base.ar + 75;
            }
        }
        public override int meret
        {
            get
            {
                return base.meret;
            }
        }
        public override string info
        {
            get
            {
                return base.info + "+ kukorica ";
            }
        }
        public Kukorica(AlapPizza p) : base(p) { }
    }
    #endregion

    #region Olajbogyó
    public class Olajbogyo : PizzaDecorator
    {
        public override int ar
        {
            get
            {
                return base.ar + 120;
            }
        }
        public override int meret
        {
            get
            {
                return base.meret;
            }
        }
        public override string info
        {
            get
            {
                return base.info + "+olajbogyó";
            }
        }
        public Olajbogyo(AlapPizza p) : base(p) { }
    }
    #endregion

    #region Császárszalonna
    public class Csaszarszalonna : PizzaDecorator
    {
        public override int ar
        {
            get
            {
                return base.ar + 125;
            }
        }
        public override int meret
        {
            get
            {
                return base.meret;
            }
        }
        public override string info
        {
            get
            {
                return base.info + "+ császárszalonna ";
            }
        }
        public Csaszarszalonna(AlapPizza p) : base(p) { }
    }
    #endregion

    #region Szalámi
    public class Szalami : PizzaDecorator
    {
        public override int ar
        {
            get
            {
                return base.ar + 135;
            }
        }
        public override int meret
        {
            get
            {
                return base.meret;
            }
        }
        public override string info
        {
            get
            {
                return base.info + "+ szalámi ";
            }
        }
        public Szalami(AlapPizza p) : base(p) { }
    }
    #endregion

   
    #region Tejföl
    public class Tejfol : PizzaDecorator
    {
        public override int ar
        {
            get
            {
                return base.ar + 90;
            }
        }
        public override int meret
        {
            get
            {
                return base.meret;
            }
        }
        public override string info
        {
            get
            {
                return base.info + "+ tejföl ";
            }
        }
        public Tejfol(AlapPizza p) : base(p) { }
    }
    #endregion

    #region Ananász
    public class Ananasz : PizzaDecorator
    {
        public override int ar
        {
            get
            {
                return base.ar + 120;
            }
        }
        public override int meret
        {
            get
            {
                return base.meret;
            }
        }
        public override string info
        {
            get
            {
                return base.info + "+ ananász ";
            }
        }
        public Ananasz(AlapPizza p) : base(p) { }
    }
    #endregion

    #region Paradicsom
    public class Paradicsom : PizzaDecorator
    {
        public override int ar
        {
            get
            {
                return base.ar + 20;
            }
        }
        public override int meret
        {
            get
            {
                return base.meret;
            }
        }
        public override string info
        {
            get
            {
                return base.info + "+ paradicsom ";
            }
        }
        public Paradicsom(AlapPizza p) : base(p) { }
    }
    #endregion

    #region Erőspaprika
    public class Erospaprika : PizzaDecorator
    {
        public override int ar
        {
            get
            {
                return base.ar + 40;
            }
        }
        public override int meret
        {
            get
            {
                return base.meret;
            }
        }
        public override string info
        {
            get
            {
                return base.info + "+ erőspaprika ";
            }
        }
        public Erospaprika(AlapPizza p) : base(p) { }

    }
    #endregion

    #region Hagyma
    public class Hagyma : PizzaDecorator
    {
        public override int ar
        {
            get
            {
                return base.ar + 20;
            }
        }
        public override int meret
        {
            get
            {
                return base.meret;
            }
        }
        public override string info
        {
            get
            {
                return base.info + "+ hagyma ";
            }
        }
        public Hagyma(AlapPizza p) : base(p) { }

    }
    #endregion

    #region Chili
    public class Chili : PizzaDecorator
    {
        public override int ar
        {
            get
            {
                return base.ar + 70;
            }
        }
        public override int meret
        {
            get
            {
                return base.meret;
            }
        }
        public override string info
        {
            get
            {
                return base.info + "+ chili ";
            }
        }
        public Chili(AlapPizza p) : base(p) { }

    }
    #endregion

    #region Bab
    public class Bab : PizzaDecorator
    {
        public override int ar
        {
            get
            {
                return base.ar + 100;
            }
        }
        public override int meret
        {
            get
            {
                return base.meret;
            }
        }
        public override string info
        {
            get
            {
                return base.info + "+ bab ";
            }
        }
        public Bab(AlapPizza p) : base(p) { }

    }
    #endregion

    #region Csirkemájas ragu
    public class Csirkemaj : PizzaDecorator
    {
        public override int ar
        {
            get
            {
                return base.ar + 140;
            }
        }
        public override int meret
        {
            get
            {
                return base.meret;
            }
        }
        public override string info
        {
            get
            {
                return base.info + "+ csirkemáj ";
            }
        }
        public Csirkemaj(AlapPizza p) : base(p) { }

    }
    #endregion

    #region Fokhagyma
    public class Fokhagyma : PizzaDecorator
    {
        public override int ar
        {
            get
            {
                return base.ar + 70;
            }
        }
        public override int meret
        {
            get
            {
                return base.meret;
            }
        }
        public override string info
        {
            get
            {
                return base.info + "+ fokhagyma ";
            }
        }
        public Fokhagyma(AlapPizza p) : base(p) { }

    }
    #endregion

    #endregion
}
