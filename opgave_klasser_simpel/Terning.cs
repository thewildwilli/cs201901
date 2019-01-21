using System;
using System.Collections.Generic;
using System.Text;

namespace opgave_klasser_simpel
{
  public class Terning
  {
        private int værdi;

    public Terning(int værdi)
    {
            this.Værdi = værdi;
    }

    public int Værdi { get => this.værdi; set => this.værdi = value; }
  }
}
