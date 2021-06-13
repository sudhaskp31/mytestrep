using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opertoroverloading
{
    class Classroom
    {
        public int Id { get; set; }
        public int Strength { get; set; }
        public string Incharge { get; set; }
        public Classroom()
        {

        }
        public Classroom(int id,int strength,string incharge)
        {
            Id = id;
            Strength = strength;
            Incharge = incharge;
        }
        public static Classroom operator+(Classroom c1,Classroom c2)
        {
            Classroom cr = new Classroom();
            cr.Id = c1.Id + c2.Id;
            cr.Incharge = c2.Incharge;
            cr.Strength = c1.Strength + c2.Strength;
            return cr;
        }
        public override string ToString()
        {
            
            {
                return "Class ID " + Id + "Strength " + Strength + "Incharge: " + Incharge;
            }
        }
    }
}
