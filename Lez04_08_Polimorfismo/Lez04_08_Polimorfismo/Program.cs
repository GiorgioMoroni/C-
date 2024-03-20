namespace Lez04_08_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona studUno = new Studente("Giovanni", "Pace", "AB1234");
            Persona studDue = new Studente("Valeria", "Verdi", "AB1235");

            Persona docUno = new Docente("Mario", "Rossi", "Fisica", "Fisica");
            Persona docDue = new Docente("Maria", "Bianchi", "Ingegneria", "Matematica");

            List<Persona> list = new List<Persona>();
            list.Add(studUno);
            list.Add(studDue);  
            list.Add(docUno);
            list.Add(docDue);

            for (int i = 0; i < list.Count; i++)
            {
                list[i].stampaDettaglio();
            }

            for (int i = 0; i < list.Count; i++)
            {
                //Se voglio stampare in maniera personalizzata da studente non posso farlo senza questa frazione di codice perche due elementi sono di tipo Docente
                if (list[i].GetType() == typeof(Studente))
                {
                    Studente temp = (Studente)list[i];
                    temp.stampaStudentePersonalizzato();
                } else if (list[i].GetType() == typeof(Docente))
                {
                    Docente temp = (Docente)list[i];
                    temp.stampaStudentePersonalizzato();
                }
            }



        }
    }
}
