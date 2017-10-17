using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace App11
{
    [Table("Mis datos")]
    public class TESHDatos

    {
        string id;
        string dato1;
        string dato2;
        string dato3;
        string dato4;
        string dato5;
        string dato6;
        string dato7;
        string dato8;
        string dato9;
        [PrimaryKey, Unique, MaxLength(8)]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        [Column("Nombre"), MaxLength(20)]
        public string Dato1
        {
            get { return dato1; }
            set { dato1 = value; }
        }
        [Column("Apellidos"), MaxLength(30)]
        public string Dato2
        {
            get { return dato2; }
            set { dato2 = value; }
        }
        [Column("direccion"), MaxLength(30)]
        public string Dato3
        {
            get { return dato3; }
            set { dato3 = value; }
        }
        [Column("Telefono"), MaxLength(30)]
        public string Dato4
        {
            get { return dato4; }
            set { dato4 = value; }
        }
        [Column("carrera"), MaxLength(30)]
        public string Dato5
        {
            get { return dato5; }
            set { dato5 = value; }
        }
        [Column("semestre"), MaxLength(30)]
        public string Dato6
        {
            get { return dato6; }
            set { dato6 = value; }
        }
        [Column("Matricula"), MaxLength(30)]
        public string Dato7
        {
            get { return dato7; }
            set { dato7 = value; }
        }
        [Column("Correo"), MaxLength(30)]
        public string Dato8
        {
            get { return dato8; }
            set { dato8 = value; }
        }
        [Column("HitHub"), MaxLength(30)]
        public string Dato9
        {
            get { return dato9; }
            set { dato9 = value; }
        }
    }
}