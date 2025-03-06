using Animal.Infrastructure;
using Animal.Infrastructure.Entities;
using Animal.Infrastructure.Services;
using System.Text;

namespace PostgresProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Передаю вітання нашим друзям Броненосцям. :)!");

            var context = new AppAnimalContext();
            var repository = new Repository<Specie>(context);
            var specieService = new SpecieService(repository);

            try
            {
                var entity = new Specie { Name = "Кіт" };
                specieService.Add(entity);
                Console.WriteLine("Вид додано успішно!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}
