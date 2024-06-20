using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using API_Jo.Models;

namespace API_Jo.TempDB
{
    public class DonasiJSON
    {
        private readonly string _filePath;
        private List<Donasi> _LDonasi;

        public DonasiJSON(string filePath)
        {
            _filePath = filePath;
            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                _LDonasi = JsonSerializer.Deserialize<List<Donasi>>(json);
            }
            else
            {
                _LDonasi = new List<Donasi>();
            }
        }

        private void Save()
        {
            var json = JsonSerializer.Serialize(_LDonasi);
            File.WriteAllText(_filePath, json);
        }

        public IEnumerable<Donasi> GetAll() => _LDonasi;

        public Donasi Get(int id) => _LDonasi.FirstOrDefault(d => d.Id == id);

        public Donasi Add(Donasi d)
        {
            d.Id = _LDonasi.Any() ? _LDonasi.Max(d => d.Id) + 1 : 1;
            _LDonasi.Add(d);
            Save();
            return d;
        }

        public bool Remove(int id)
        {
            var d = Get(id);
            if (d == null) return false;
            _LDonasi.Remove(d);
            Save();
            return true;
        }

        public bool Update(Donasi d)
        {
            var pilih = Get(d.Id);
            if (pilih == null) return false;
            pilih.Nama = d.Nama;
            pilih.Nominal = d.Nominal;
            pilih.Metode = d.Metode;
            Save();
            return true;
        }
    }
}
