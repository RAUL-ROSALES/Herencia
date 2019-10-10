using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Paciente p = new Paciente();
            p.id = 1;
            p.nombre = "pancho";
            p.sexo = "Hombre";
            p.telefono = "664-1234-567";
            p.correo = "nose_quehagoaqui@gmail.com";
            p.tipo_de_paciente = "urgente";
            p.fecha_de_nacimiento = "12/10/1990";

            Enfermera e = new Enfermera();
            e.id = 1;
            e.nombre = "lolita";
            e.sexo = "Mujer";
            e.area = "medicina";
            e.correo = "enfermera_1@gmail.com";
            e.telefono = "664-1234-568";
            e.fecha_de_nacimiento = "11/08/1990";

            Especialista es = new Especialista();
            es.id = 1;
            es.nombre = "jisus";
            es.sexo = "Hombre";
            es.Consultorio = "Clinica 1 consultorio # 10";
            es.telefono = "664-9876-543";
            es.correo = "el_mas_chingon_que_hay_en_tijuana@gmail.com";
            es.fecha_de_nacimiento = "20/09/1987";
            es.especialidad = "cardiologo";

            Medicofamiliar m = new Medicofamiliar();
            m.id = 1;
            m.nombre = "lupis";
            m.sexo = "Mujer";
            m.Consultorio = "Clinica 1 consultorio # A5";
            m.telefono = "664-4568-987";
            m.correo = "g_g@gmail.com";
            m.fecha_de_nacimiento = "08/07/1997";
            m.Generico = "Medico Familiar";

            Console.WriteLine("\nNombre: " + p.nombre + "\nSexo: " + p.sexo + "\nFecha de nacimiento: " + p.fecha_de_nacimiento + "\n# de telefono: " + p.telefono + "\ncorreo electromico : " + p.correo + "\nUrgencia :" + p.tipo_de_paciente);
            Console.WriteLine("\nNombre: " + e.nombre + "\nSexo: " + e.sexo + "\nFecha de nacimineto: " + e.fecha_de_nacimiento + "\n# de telefono: " + e.telefono + "\ncorreo electronico: " + e.correo + "\nArea: " + e.area);
            Console.WriteLine("\nNombre: " + es.nombre + "\nSexo: " + es.sexo + "\nConsultotio " + es.Consultorio + "\nFecha de nacimiento: " + es.fecha_de_nacimiento + "\n# de telefono: " + es.telefono + "\ncorreo electromico : " + es.correo + "\nEspecialidad: " + es.especialidad);
            Console.WriteLine("\nNombre: " + m.nombre + "\nSexo: " + m.sexo + "\nConsultorio: " + m.Consultorio + "\nFecha de nacimiento: " + m.fecha_de_nacimiento + "\n# De Telefono "+m.telefono+ "\nCorreo Electronico: "+m.correo+ "\nEspecialidad: "+m.Generico);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
