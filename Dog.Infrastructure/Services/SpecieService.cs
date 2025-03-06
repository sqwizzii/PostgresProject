using Animal.Infrastructure.Entities;
using Animal.Infrastructure.Interfaces;

namespace Animal.Infrastructure.Services
{
    public class SpecieService
    {
        private readonly IRepository<Specie> _repository;

        public SpecieService(IRepository<Specie> repository)
        {
            _repository = repository;
        }

        public Specie? GetById(int id) => _repository.GetById(id);

        public IEnumerable<Specie> GetAll() => _repository.GetAll();

        public void Add(Specie specie)
        {
            if (string.IsNullOrWhiteSpace(specie.Name))
                throw new ArgumentException("Назва не може бути порожньою!");
            _repository.Add(specie);
            _repository.SaveChanges();
        }

        public void Update(Specie specie)
        {
            if (string.IsNullOrWhiteSpace(specie.Name))
                throw new ArgumentException("Назва не може бути порожньою!");
            _repository.Update(specie);
            _repository.SaveChanges();
        }

        public void Delete(int id)
        {
            var specie = _repository.GetById(id);
            if (specie != null)
            {
                _repository.Delete(specie);
                _repository.SaveChanges();
            }
        }
    }
}
