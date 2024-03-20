using DB_Lez03_DAL.DAL;

namespace DB_Lez03_DAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SudenteDAL stuDal = new SudenteDAL();
            //stuDal.insert(new Models.Studente() { });

            DocenteDAL.getInstance().insert(new Models.Docente() { });
        }
    }
}
