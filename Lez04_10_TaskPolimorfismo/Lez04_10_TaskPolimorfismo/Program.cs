using Lez04_10_TaskPolimorfismo.Classes;

namespace Lez04_10_TaskPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Creare un sistema che mantenga traccia degli oggetti contenuti nelle stanze.
             * Di ogni oggetto voglio conoscere -Nome -Descrizione -Valore dell'oggetto
             * 
             * Di ogni stanza voglio conoscere il nome
             * 
             */

            Oggetto ogg1 = new Oggetto("Spazzolino", "Spazzola i denti", 9.9f);
            Oggetto ogg2 = new Oggetto("Dentifricio", "Pulisce i denti", 7.9f);

            Oggetto ogg3 = new Oggetto("Padella", "Cuoce", 12.9f);
            Oggetto ogg4 = new Oggetto("Forno", "Scalda", 100.0f);

            Oggetto ogg5 = new Oggetto("Orologio", "Cona le ore", 50.0f);
            Oggetto ogg6 = new Oggetto("Divano", "Relax", 150.0f);

            Stanza cucina = new Stanza("Cucina");
            Stanza bagno = new Stanza("Bagno");
            Stanza salone = new Stanza("Salone");


            //cucina.stampaStanza();
            //salone.stampaStanza();
            //bagno.stampaStanza();

            //ogg1.stampaOggetto();
            //ogg2.stampaOggetto();
            //ogg3.stampaOggetto();
            //ogg4.stampaOggetto();
            //ogg5.stampaOggetto();
            //ogg6.stampaOggetto();
            //bagno.aggiugniOggetto(ogg1);

            
            bool insAbilitato = true;

          
            while (insAbilitato)
            {
                Console.WriteLine("Cosa vuoi fare?\nInserisci la stanza, controlla una stanza o premi Q per uscire:");
                string? inputStanza = Console.ReadLine();

                if (inputStanza != null && inputStanza.Equals("Q"))
                {
                    insAbilitato = false;
                }
                else if (inputStanza != null && inputStanza.Equals("controllo"))
                {
                    Console.WriteLine("Scegli la stanza da controllare:");
                    string? inputCheck = Console.ReadLine();

                    if (inputCheck == "bagno")
                    {
                        bagno.elencoOggetti(bagno);

                    }
                    else if (inputCheck == "cucina")
                    {
                        cucina.elencoOggetti(cucina);
                    }
                    else if (inputCheck == "salone")
                    {
                        salone.elencoOggetti(salone);
                    }
                     
                }
                else 
                { 

                    switch (inputStanza)
                    {
                        case "cucina":
                            Console.Write($"Sei entrato in ");
                            cucina.stampaStanza();
                            break;

                        case "bagno":
                            Console.Write($"Sei entrato in ");
                            bagno.stampaStanza();
                            break;

                        case "salone":
                            Console.Write($"Sei entrato in ");
                            salone.stampaStanza();
                            break;

                        default:
                            break;
                    }

                    Console.WriteLine("Inserisci oggetto");
                    string? inputOgg = Console.ReadLine();

                    if (inputStanza == "bagno")
                    {
                        switch (inputOgg)
                        {
                            case "spazzolino":
                                bagno.aggiugniOggetto(ogg1);
                                break;

                            case "dentifricio":
                                bagno.aggiugniOggetto(ogg2);
                                break;

                            default:
                                    
                                break;
                        }
                    } 

                    if (inputStanza == "cucina")
                    {
                        switch (inputOgg)
                        {
                            case "padella":
                                cucina.aggiugniOggetto(ogg3);
                                break;

                            case "forno":
                                cucina.aggiugniOggetto(ogg4);
                                break;

                            default:
                                    
                                break;
                        }
                    }

                    if (inputStanza == "salone")
                    {
                        switch (inputOgg)
                        {
                            case "orologio":
                                salone.aggiugniOggetto(ogg5);
                                break;

                            case "divano":
                                salone.aggiugniOggetto(ogg6);
                                break;

                            default:
                                    
                                break;

                        }
                    }
                    


                    
                    

                }

            }
            

        }
    }
}
