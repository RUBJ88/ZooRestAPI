using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.SignalR.Protocol;

namespace Zoo.Manager
{
    public class AnimalManager : IAnimals, IITem
    {


        private static List<Animal> _items = new List<Animal>()
        {
            new Animal() {Alder = 1, Køn = "dreng", Navn = "Oluf", Slags = "abe"},
            new Animal() {Alder = 2, Køn = "dreng", Navn = "Christopher", Slags = "Giraf"},
            new Animal() {Alder = 3, Køn = "dreng", Navn = "seb", Slags = "Slange"},
            new Animal() {Alder = 4, Køn = "pige", Navn = "Jørn", Slags = "Bjørn"},
            new Animal() {Alder = 5, Køn = "dreng", Navn = "holgar", Slags = "abe"},
            new Animal() {Alder = 6, Køn = "dreng", Navn = "Christopher", Slags = "Giraf"},
            new Animal() {Alder = 7, Køn = "dreng", Navn = "seb", Slags = "Slange"},
            new Animal() {Alder = 8, Køn = "pige", Navn = "Jørn", Slags = "Bjørn"},
            new Animal() {Alder = 9, Køn = "pige", Navn = "oluf", Slags = "abe"},
            new Animal() {Alder = 10, Køn = "dreng", Navn = "Christopher", Slags = "Giraf"},
            new Animal() {Alder = 11, Køn = "pige", Navn = "seb", Slags = "Slange"},
            new Animal() {Alder = 12, Køn = "intetkøn", Navn = "Jørn", Slags = "Bjørn"},
        };


        public List<Animal> Get()
        {
            return new List<Animal>(_items);
        }

        public Animal Create(Animal animals)
        {
            {
                if (_items.Exists(b => b.Navn == b.Navn))
                    throw new ArgumentException("Stelnummer findes allerede");

                _items.Add(animals);
                return animals;
            }
        }

        public Animal Update(string an, Animal animal)
        {
            Animal updateAnimal = Get(an);
            if (updateAnimal is not null)
            {
                updateAnimal.Slags = animal.Slags;
                updateAnimal.Alder = animal.Alder;
                updateAnimal.Køn = animal.Køn;
                updateAnimal.Navn = animal.Navn;

            }

            return updateAnimal;

        }

        public Animal Delete(string an)
        {
            Animal deleteAnimal = Get(an);
            _items.Remove(deleteAnimal);
            return deleteAnimal;
        }

        public Animal Get(string an)

        {
            Animal animal = _items.Find(b => b.Navn == an);
            if (animal is null)
            {
                throw new KeyNotFoundException();
            }

            return animal; 
        }

        public Animal GetGender(string an)
        {
            if (!_items.Exists(b => b.Navn == an))
                throw new KeyNotFoundException();

            return _items.Find(b => b.Navn == an);
        }

        public List<Animal> SearchQuanity(int? lowQuanity, int? highQuanity)
        {
            List<Animal> animalTemp = (lowQuanity is null) ? _items : _items.Where(b => b.Alder >= lowQuanity).ToList();

            return (highQuanity is null) ? animalTemp : animalTemp.Where(b => b.Alder <= highQuanity).ToList();
        }
            public IEnumerable<Item> GetWithFilter(ItemsFeature filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item>GetFromSubstring(string substring)

        {
            if (substring == null)
            {
                _items.Where(i => i.Navn.Contains(substring));
            }

            throw new ArgumentException("name dont excist");



        }

        public IEnumerable<Animal> GetRange(int low, int high)
        {
            if (low > _items.Count)
            {
                throw new ArgumentNullException();
            }

            if (high > _items.Count)
            {
                throw new ArgumentException();
            }

            

            List<Animal>animal= new List<Animal>();

            for (int i = low; i < high; i++)
            {
                animal.Add(_items[i]);
            }

            for (int i = high; i > low; i--)
            {
                animal.Add(_items[i]);
            }

            return animal;

        }


    }
}


