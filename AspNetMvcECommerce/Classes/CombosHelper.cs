using AspNetMvcECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvcECommerce.Classes
{
    public class CombosHelper : IDisposable
    {
        private static ECommerceContext db = new ECommerceContext();

        public static List<Departaments> GetDepartaments ()
        {
            var departaments = db.Departaments.ToList();
            departaments.Add(new Departaments { DepartamentsId = 0, Name = "[ Selecione um Departamento ]" });
            departaments = departaments.OrderBy(d => d.Name).ToList();
            return departaments;
        }

        public static List<City> GetCities ()
        {
            var cities = db.Cities.ToList();
            cities.Add(new City { CityId = 0, Name = "[ Selecione uma Cidade ]" });
            cities = cities.OrderBy(d => d.Name).ToList();
            return cities;
        }

        public static List<Company> GetCompanies()
        {
            var companies = db.Companies.ToList();
            companies.Add(new Company { CompanyId = 0, Name = "[ Selecione uma Companhia ]" });
            companies = companies.OrderBy(d => d.Name).ToList();
            return companies;
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}