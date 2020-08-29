using System.Threading.Tasks;
using AutoMapper;

namespace Application.Profiles
{
    public interface IProfileReader
    {
        Task<Profile> ReadProfile(string username);
    }
}