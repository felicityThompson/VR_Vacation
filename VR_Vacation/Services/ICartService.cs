using VR_Vacation.Models;

namespace VR_Vacation.Services
{
    public interface ICartService
    {
        /// <summary>
        /// Get current cart session
        /// </summary>
        /// <returns>Cart</returns>
        Cart GetCart();

        /// <summary>
        /// Add package to cart
        /// </summary>
        /// <param name="id">int id</param>
        /// <returns>void</returns>
        void AddPackage(int id);

        /// <summary>
        /// Remove package from cart
        /// </summary>
        /// <param name="id">int id</param>
        /// <returns>void</returns>
        void RemovePackage(int id);

        /// <summary>
        /// Add experience to cart
        /// </summary>
        /// <param name="id">int id</param>
        /// <returns>void</returns>
        void AddExperience(int id);

        /// <summary>
        /// Remove experience from cart
        /// </summary>
        /// <param name="id">int id</param>
        /// <returns>void</returns>
        void RemoveExperience(int id);

        /// <summary>
        /// Check out and empty cart
        /// </summary>
        /// <param name="id">int id</param>
        /// <returns>order id</returns>
        int Checkout(int id);
    }
}
