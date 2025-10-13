using SportReserve_Shared.Models.Race;
using SportReserve_Shared.Models.Reservation.Add;

namespace SportReserve_Reservations.Interfaces
{
    public interface IValentineRaceReservationValidator
    {
        void ValidateValentineRaceReservation(AddValentineRace reservation, GetRaceDto getRaceDto, GetRaceTraceDto getRaceTraceDto, string userId, string userIdFromToken);
    }
}
