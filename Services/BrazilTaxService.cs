﻿
namespace Rental_of_Vehicles.Services
{
    internal class BrazilTaxService
    {
        public double Tax (double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
            
        }
    }
}
