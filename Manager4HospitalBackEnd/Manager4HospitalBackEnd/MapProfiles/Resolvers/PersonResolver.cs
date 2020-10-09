using AutoMapper;
using DAL.Models;
using Manager4HospitalBackEnd.Models;
using System;
using System.IO;

namespace Manager4HospitalBackEnd.MapProfiles.Resolvers
{
    public class PersonResolver : IValueResolver<Person, PersonViewModel, string>
    {
        public string Resolve(Person person, PersonViewModel personViewModel, string destMember, ResolutionContext context)
        {
            var file = File.ReadAllBytes($"./Photo/{person.PathToFile}");
            return Convert.ToBase64String(file);
        }
    }
}
