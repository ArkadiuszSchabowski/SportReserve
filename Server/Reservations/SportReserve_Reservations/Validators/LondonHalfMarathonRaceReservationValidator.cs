using SportReserve_Reservations.Interfaces;
using SportReserve_Shared.Models.Race;
using SportReserve_Shared.Models.Reservation.Add;

namespace SportReserve_Reservations.Validators
{
    public class LondonHalfMarathonRaceReservationValidator : ILondonHalfMarathonRaceReservationValidator
    {
        private readonly IReservationValidator _reservationValidator;

        public LondonHalfMarathonRaceReservationValidator(IReservationValidator reservationValidator)
        {
            _reservationValidator = reservationValidator;
        }

        public void ValidateLondonHalfMarathonRaceReservation(AddLondonHalfMarathonRace reservation, GetRaceDto getRaceDto, GetRaceTraceDto getRaceTraceDto, string userId, string userIdFromToken)
        {
            string raceName = "London Half-Marathon Race";

            _reservationValidator.ValidateRace(getRaceDto, getRaceTraceDto, raceName, userId, userIdFromToken);
        }
    }
}
