using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class HalcónMilenario: Nave
    {
        List<Enemigo> enemigo;
        public HalcónMilenario(PuntoZY p, int SW,int SH, List<Enemigo> enemigo)
            :base(p,SW,SH)
        {
            this.enemigo = enemigo;
        }

        public void Move(int direccion) //serpi debe moverse
        {

            if (direccion == 0) //condicionales para saber la direccion
            {
                ModUbi(GetZ() + 1, GetY());
            }
            else if (direccion == 1) //condicionales para saber la direccion
            {
                ModUbi(GetZ() , GetY() + 1);
            }
            else if (direccion == 2) //condicionales para saber la direccion
            {
                ModUbi(GetZ() - 1, GetY());
            }
            else if (direccion == 3) //condicionales para saber la direccion
            {
                ModUbi(GetZ(), GetY() -1);
            }

        }

        public bool IsDead() //serpi tambien muere :c
        {
            if (GetZ() < 0 || GetZ() >= GetSH() || GetY() < 0 || GetY() >= GetSW()) //si serpi toca los bordes muere :v
                return true; //dice que si murio 

            for (int i = 0; i < enemigo.Count - 1; i++) //ciclo para saber si serpi se toca ( ͡° ͜ʖ ͡°)
            {
                if (enemigo[i].GetZ() == GetZ() && enemigo[i].GetY() == GetY()) //serpi se toco y merece morir ( ͡° ͜ʖ ͡°)
                    return true; //murio :c
            }
            return false; //si serpi sigue las reglas vivira una ejecucion feliz con un puntaje alto!
        }

        public override void Drawn(Form1 form)
        {
            throw new NotImplementedException();
        }
    }
}
