
using System.Collections.Generic;
using VR_Vacation.Models;

namespace VR_Vacation.Services
{
    public interface ICartService
    {
        Cart GetCart();

        void AddPackage(int it);

        void RemovePackage(int it);

        void AddExperience(int id);

        void RemoveExperience(int id);
    }
}
