using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirthdayApp.Models
{
    public static class Veritabani
    {
        private static Dictionary<string, DavetiyeModel> _liste;
        static Veritabani()
        {
            _liste = new Dictionary<string, DavetiyeModel>();

            _liste.Add("Ali", new DavetiyeModel
            {
                Ad = "Ali",
                Eposta = "alitopcan@outlook.com",
                KatilmaDurumu = true
            });
            _liste.Add("Hasan", new DavetiyeModel
            {
                Ad = "Hasan",
                Eposta = "hasan@gmail.com",
                KatilmaDurumu = false
            });
            _liste.Add("Veli", new DavetiyeModel
            {
                Ad = "Veli",
                Eposta = "veli@hotmail.com",
                KatilmaDurumu = true
            });
        }
        public static void Add(DavetiyeModel model)
        {
            string key = model.Ad.ToLower();
            if (_liste.ContainsKey(key))
            {
                _liste[key] = model;
            }
            else
            {
                _liste.Add(key, model);
            }
        }

        public static IEnumerable<DavetiyeModel> Liste
        {
            get { return _liste.Values; }
        }
    }
}