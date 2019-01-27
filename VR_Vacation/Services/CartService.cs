using System.Linq;
using System.Web;
using VR_Vacation.Models;
using VR_Vacation.Repositories;

namespace VR_Vacation.Services
{
    public class CartService : ICartService
    {
        private IVacationRepository _vacationRepository;
        private Cart _cart;

        public CartService(IVacationRepository vacationRepository)
        {
            _vacationRepository = vacationRepository;
            _cart = Cart();
        }

        private Cart Cart()
        {
            _cart = HttpContext.Current.Session["Cart"] as Cart;
            if (_cart == null)
            {
                _cart = new Cart();
                HttpContext.Current.Session["Cart"] = _cart;
            }

            return _cart;
        }

        public Cart GetCart()
        {
            return _cart;
        }

        public void AddPackage(int id)
        {
            var package = _vacationRepository.GetPackage(id);

            _cart.Packages.Add(package);
            _cart.TotalAmount += package.Price;
        }

        public void RemovePackage(int id)
        {
            var package = _vacationRepository.GetPackage(id);

            _cart.Packages.Remove(package);
            _cart.TotalAmount -= package.Price;
        }

        public void AddExperience(int id)
        {
            var experience = _vacationRepository.GetExperience(id);

            _cart.Experiences.Add(experience);
            _cart.TotalAmount += experience.Price;
        }

        public void RemoveExperience(int id)
        {
            var experience = _vacationRepository.GetExperience(id);

            _cart.Experiences.Remove(experience);
            _cart.TotalAmount -= experience.Price;
        }

        public int Checkout(int id)
        {
            OrderVm order = new OrderVm
            {
                Packages = _cart.Packages.ToList(),
                Experiences = _cart.Experiences.ToList(),
                UserId = id,
                Total = _cart.TotalAmount
            };

            var orderNumber = _vacationRepository.PostOrder(order);

            if (orderNumber > 0)
                HttpContext.Current.Session["Cart"] = null;

            return orderNumber;
        }
    }
}