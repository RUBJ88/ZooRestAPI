using Microsoft.AspNetCore.Mvc.Filters;

namespace Zoo.Manager
{
    public interface IAnimals
    {

        // CRUD
        List<Animal> Get();
        Animal Create(Animal animals);
        Animal Update(String an, Animal animal);
        Animal Delete(String an);

        Animal Get(String an);

        Animal GetGender(String an);

        List<Animal> SearchQuanity(int? lowQuanity, int? highQuanity);

        public IEnumerable<Animal> GetRange(int low, int high);



    }


}
