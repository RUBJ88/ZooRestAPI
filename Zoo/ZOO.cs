using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class ZOO
    {
        private int _id;
        private string _navn;
        private string _by;
        private string _adresse;
        private int _telefon;

        public ZOO(int id, string navn, string by, string adresse, int telefon)
        {
            _id = id;
            _navn = navn;
            _by = by;
            _adresse = adresse;
            _telefon = telefon;
        }

        public int Id { get; set; }

        public string navn { get; private set; }

        public string by { get; set; }

        public string adresse { get; set; }

        public int telefon { get; set; }

        public override string? ToString()
        {
            return $"{nameof(_id)}: {_id}, {nameof(_navn)}: {_navn}, {nameof(_by)}: {_by}, {nameof(_adresse)}: {_adresse}, {nameof(_telefon)}: {_telefon}";
        }
    }
}

