using SportReserve_Shared.Models.Race;
using SportReserve_Shared.Models.Reservation.Add;

namespace SportReserve_Reservations.Interfaces
{
    public interface ILondonHalfMarathonRaceReservationValidator
    {
        void ValidateLondonHalfMarathonRaceReservation(AddLondonHalfMarathonRace reservation, GetRaceDto getRaceDto, GetRaceTraceDto getRaceTraceDto, string userId, string userIdFromToken);
    }
}
