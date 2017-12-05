using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    abstract class Nave
    {
        PuntoZY ubucacion;
        private int SH;
        private int SW;
        public Nave(PuntoZY ubucacion, int SH,int SW)
        {
            this.ubucacion = ubucacion;
            this.SH = SH;
            this.SW = SW;
        }

        abstract public void Drawn(Form1 form);

        public void ModUbi(int z, int y)
        {
            PuntoZY nueva = new PuntoZY(z, y);
            this.ubucacion = nueva;
        }

        public int GetZ()
        {
            return ubucacion.z;
        }

        public int GetY()
        {
            return ubucacion.y;
        }

        public int GetSH()
        {
            return SH;
        }

        public int GetSW()
        {
            return SW;
        }
    }
}
