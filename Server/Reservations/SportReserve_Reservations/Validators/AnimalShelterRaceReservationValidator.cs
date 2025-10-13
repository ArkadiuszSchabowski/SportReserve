using SportReserve_Reservations.Interfaces;
using SportReserve_Shared.Exceptions;
using SportReserve_Shared.Models.Race;
using SportReserve_Shared.Models.Reservation.Add;

namespace SportReserve_Reservations.Validators
{
    public class AnimalShelterRaceReservationValidator : IAnimalShelterRaceReservationValidator
    {
        private readonly IReservationValidator _reservationValidator;

        public AnimalShelterRaceReservationValidator(IReservationValidator reservationValidator)
        {
            _reservationValidator = reservationValidator;
        }

        public void ValidateAnimalShelterRaceReservation(AddAnimalShelterRace reservation, GetRaceDto getRaceDto, GetRaceTraceDto getRaceTraceDto, string userId, string userIdFromToken)
        {
            string raceName = "Run for the Animal Shelter";

            if(reservation.DonationAmount < 0)
            {
                throw new BadRequestException("Please enter a positive number.");
            }

            if(reservation.DonationAmount > 1000000)
            {
                throw new BadRequestException("Please enter a value up to 1,000,000 GBP.");
            }

            _reservationValidator.ValidateRace(getRaceDto, getRaceTraceDto, raceName, userId, userIdFromToken);
        }
    }
}
